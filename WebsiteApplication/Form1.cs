namespace WebsiteApplication
{
    public partial class Form1 : Form
    {
        int topbar_size = 23;
        private void WebView_ReScale()
        {
            this.webView21.Location = new System.Drawing.Point(0, topbar_size);
            //                                                    width        ,        height          -   topbar
            this.webView21.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height - topbar_size);
        }

        public Form1()
        {
            InitializeComponent();
            WebView_ReScale();
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string cur_url = this.webView21.Source.ToString();
            //this.Text = cur_url;
            this.domainname.Text = cur_url;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            WebView_ReScale();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Uri main_website = new System.Uri("https://hostermax.co.uk");
            this.webView21.Source = main_website;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Uri overplan_website = new System.Uri("https://overplan.hostermax.co.uk");
            this.webView21.Source = overplan_website;
        }
    }
}
