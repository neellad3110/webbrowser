using EasyTabs;
using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Loki_Browser
{
    public partial class NewTab_Container : TitleBarTabs
    {
        public NewTab_Container()
        {
            InitializeComponent(); 
            
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        
        private void NewTab_Container_Load(object sender, EventArgs e)
        {

        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Loki_browser
                {
                    Text = "New Tab"
                }
            };
        }
    }

}
