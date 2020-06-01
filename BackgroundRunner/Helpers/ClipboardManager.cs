using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace BackgroundRunner.Helpers
{
    public class ClipboardManager
    {
        public static string GetClipboardContent()
        {
            try
            {
                var result = "";
                RunAsSTAThread(
                    () =>
                    {
                        result = Clipboard.GetText(TextDataFormat.Text);
                    });
                return result;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public static void InsertClipboardText(string text)
        {
            try
            {
                Task waiting = asyncPopulate(text);
            }
            catch (Exception ex)
            {

            }
        }

        private static async Task asyncPopulate(string text)
        {
            Task wait = Task.Delay(100);
            await wait;
            RunAsSTAThread(() =>
            {
                Clipboard.SetText(text, TextDataFormat.Text);
            });
        }

        private static void RunAsSTAThread(Action goForIt)
        {
            AutoResetEvent @event = new AutoResetEvent(false);
            Thread thread = new Thread(
                () =>
                {
                    goForIt();
                    @event.Set();
                });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            @event.WaitOne();
        }
    }
}
