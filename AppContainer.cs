using EasyTabs;

namespace Ann_Browser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new frmBrowser
                {
                    Text = "Ann Browser"
                }
            };
        }
    }
}
