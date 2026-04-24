namespace WebsiteApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string cur_url = this.webView21.Source.ToString();
            this.Text = cur_url;
        }
    }
}
