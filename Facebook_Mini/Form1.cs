using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //This code makes it so that you can move the form without the bar.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //End of mouseDown code. Use "MouseDown +=new MouseEventHandler(Form1_MouseDown);" in initialize form if you copy this.
        public Form1()
        {
            MouseDown +=new MouseEventHandler(Form1_MouseDown);
            InitializeComponent();
            webBrowser1.Navigate("http://iphone.facebook.com");
            Timer refresh = new Timer();
            refresh.Interval = 300000;
            refresh.Tick +=new EventHandler(refreshpage);
            refresh.Start();
        }

        private void refreshpage(object sender, EventArgs e)
        {
            if (webBrowser1.Url.ToString() == "http://iphone.facebook.com")
            {
                webBrowser1.Refresh();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string urlString = webBrowser1.Url.ToString().Replace("http://iphone.", "http://www.");
            Process.Start("iexplore", urlString);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://iphone.facebook.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Url.ToString() == "http://iphone.facebook.com")
            {
                webBrowser1.Refresh();
            }
        }

    }
}
