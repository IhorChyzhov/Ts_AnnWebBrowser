using EasyTabs;
using System;
using System.Windows.Forms;

namespace Ann_Browser
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new frmBrowser
                    {
                        Text = "Ann Browser"
                    }
                }
            );

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
