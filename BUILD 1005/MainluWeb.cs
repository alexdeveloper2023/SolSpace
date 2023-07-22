using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;
namespace SolSpaceOS
{
    public partial class MainluWeb : Form
    {
        public MainluWeb()
        {
            InitializeComponent();
        }

        private void OrangeWeb_Load(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = webView21.Source.ToString();
            Directory.CreateDirectory(@"C:\SolSpace\.mainluweb\plugins");
        }

        private void webView21_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.IsRedirected)
            {
                toolStripTextBox1.Text = webView21.Source.ToString();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate(toolStripTextBox1.Text);
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        { 
            if (e.IsSuccess == true)
            {
                toolStripTextBox1.Text = webView21.CoreWebView2.Source;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void MainluWeb_MaximumSizeChanged(object sender, EventArgs e)
        {
            toolStripTextBox1.Size = new Size(toolStripButton4.Width,0); ;
        }
    }
}
