using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewIssues
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomBrowser : ContentPage
	{
        public CustomBrowser(string url)
        {
            InitializeComponent();
            webView.Source = url;
        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            /*indicator.IsVisible = true;
            indicator.IsRunning = true;*/
            Debug.WriteLine("Navigating to URL: " + e.Url);
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            /*indicator.IsVisible = false;
            indicator.IsRunning = false;*/
        }
    }
}