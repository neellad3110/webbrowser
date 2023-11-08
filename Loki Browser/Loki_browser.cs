using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Loki_Browser
{
    public partial class Loki_browser : Form
    {
       

        public Loki_browser()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.bing.com");


        }
        protected TitleBarTabs ParentTabs
        {
            get { return ParentForm as TitleBarTabs; }
            
        }
        private void Loki_browser_Load(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void tab_btn_Click(object sender, EventArgs e)
        {

        }

       

       

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fwd_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // refresh_btn.Image = cancel_btn.Image;
        }


        private void user_profilr_btn_Click(object sender, EventArgs e)
        {

        }

        private void downloads_btn_Click(object sender, EventArgs e)
        {

        }

        private void settings_btn_Click(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void about_loki_btn_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
          //  refresh_btn.Image = cancel_btn.Image;
            progress_bar.Visible = true;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuToolTip1_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e)
        {

        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void progress_bar_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
