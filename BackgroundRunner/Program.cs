using System;
using System.Windows.Forms;
using BackgroundRunner.Properties;
using ConsoleHotKey;

namespace BackgroundRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCustomApplicationContext());
        }
    }

    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = new System.Drawing.Icon("./mycon.ico"),
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };
            RegisterHoteys();
        }

        private void RegisterHoteys()
        {
            HotKeyManager.RegisterHotKey(Keys.D1, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);

        }
        static void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            try
            {
                var f = new Form1();
                f.ShowDialog();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
