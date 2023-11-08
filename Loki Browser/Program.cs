using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loki_Browser
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
            NewTab_Container newTab_Container = new NewTab_Container();

            newTab_Container.Tabs.Add(
                new TitleBarTab(newTab_Container)
                {
                    Content=new Loki_browser
                    {
                        Text ="New Tab"
                    }
                });

            newTab_Container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(newTab_Container);
            Application.Run(applicationContext);

        }
    }
}
