using EasyTabs;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Ann_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                    Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            webBrowser1.Navigate("https://www.google.com/");
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnRefresh.Image = imgRefresh.Image;
            txtSearchOrUrl.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, System.EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatedEventArgs e)
        {
            btnRefresh.Image = imgSpinner.Image;
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            btnRefresh.Image = imgSpinner.Image;
        }

        private void txtSearchOrUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtSearchOrUrl.Text.Trim().Length > 0)
            {
                if (txtSearchOrUrl.Text.Contains("."))
                {
                    webBrowser1.Navigate(txtSearchOrUrl.Text.Trim());
                }
                else
                {
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q="+txtSearchOrUrl.Text.Trim().Replace("","+")+"&sourceid=opera&ie=UTF-8&oe=UTF-8");
                }
            }
        }
    }
}
