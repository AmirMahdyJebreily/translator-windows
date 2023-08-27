using Microsoft.Web.WebView2.Core;

namespace MyTranslatorWindows
{
    public partial class frmTranslator : Form
    {
        private ContextMenuStrip fruitContextMenuStrip;

        public frmTranslator()
        {
            InitializeComponent();
        }


        private void translatorPage_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {

            translatorPage.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            translatorPage.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
            translatorPage.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;
            translatorPage.CoreWebView2.Settings.AreDevToolsEnabled = false;
            translatorPage.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            translatorPage.CoreWebView2.Settings.IsStatusBarEnabled = false;
            translatorPage.CoreWebView2.Settings.IsBuiltInErrorPageEnabled = false;
            translatorPage.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;
            translatorPage.CoreWebView2.Settings.IsZoomControlEnabled = false;
            translatorPage.CoreWebView2.Settings.IsPinchZoomEnabled = false;
            translatorPage.CoreWebView2.Settings.HiddenPdfToolbarItems = Microsoft.Web.WebView2.Core.CoreWebView2PdfToolbarItems.None;

            string hostOf(string uri)
            {
                return new Uri(uri).Host;
            }

            if (hostOf(e.Uri) != hostOf(Statics.translate_uri))
            {
                translatorPage.NavigateToString(Statics.translate_uri);
            }
        }

        private void frmTranslator_Load(object sender, EventArgs e)
        {
            translatorPage.Source = new Uri(Statics.translate_uri);
        }
    }
}
