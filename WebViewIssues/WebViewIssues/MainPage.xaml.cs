using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewIssues
{
    public partial class MainPage : ContentPage
    {
        const string urlStuck = "https://www.bing.com";
        const string urlIssues = "https://santafepubliclibrary.odilo.us/opac/";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void webview1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Browser(urlStuck));
        }

        private async void customWebview1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomBrowser(urlStuck));
        }

        private async void webview2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Browser(urlIssues));
        }

        private async void customWebview2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomBrowser(urlIssues));
        }
    }
}
