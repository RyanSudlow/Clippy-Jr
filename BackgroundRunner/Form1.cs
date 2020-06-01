using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackgroundRunner.Formatters;
using BackgroundRunner.Helpers;

namespace BackgroundRunner
{
    public partial class Form1 : Form
    {
        Timer fadeInTimer = new Timer();
        Timer fadeOutTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += form1_FormClosing;
            this.LostFocus += Form1_LostFocus;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Cursor.Position;

            fadeInTimer.Interval = 10;  
            fadeInTimer.Tick += new EventHandler(fadeIn);
            fadeInTimer.Start();
        }


        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= .8)
            {
                fadeInTimer.Stop();
            }
            else
            {
                Opacity += .05;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            fadeOutTimer.Interval = 10;
            fadeOutTimer.Tick += new EventHandler(fadeOut);
            fadeOutTimer.Start();

            if (Opacity == 0)
                e.Cancel = false;

        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                fadeOutTimer.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        void Form1_LostFocus(object sender, EventArgs e)
        {
            //Close();
        }
        private void SqlSplitBtn_Click(object sender, EventArgs e)
        {
            var s = ClipboardManager.GetClipboardContent();
            var result = CommaSeperator.Format(s);
            ClipboardManager.InsertClipboardText(result);
            Close();
        }

        private void JSONBtn_Click(object sender, EventArgs e)
        {
            var s = ClipboardManager.GetClipboardContent();
            var result = JSONFormatter.Format(s);
            ClipboardManager.InsertClipboardText(result);
            Close();
        }

        private void XMLBtn_Click(object sender, EventArgs e)
        {
            var s = ClipboardManager.GetClipboardContent();
            var result = XMLFormatter.Format(s);
            ClipboardManager.InsertClipboardText(result);
            Close();
        }

        private void SqlQueryBtn_Click(object sender, EventArgs e)
        {
            var s = ClipboardManager.GetClipboardContent();
            var result = SqlFormatter.Format(s);
            ClipboardManager.InsertClipboardText(result);
            Close();
        }

        private void NumSplitBtn_Click(object sender, EventArgs e)
        {
            var s = ClipboardManager.GetClipboardContent();
            var result = CommaSeperator.Format(s, "");
            ClipboardManager.InsertClipboardText(result);
            Close();
        }

        private void StringSplitBtn_Click(object sender, EventArgs e)
        {
            var s = ClipboardManager.GetClipboardContent();
            var result = CommaSeperator.Format(s, "'");
            ClipboardManager.InsertClipboardText(result);
            Close();
        }
    }
}
