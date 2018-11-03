using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebViewIssues;
using WebViewIssues.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace WebViewIssues.UWP
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.NewWindowRequested += Control_NewWindowRequested;
            }
        }

        private void Control_NewWindowRequested(Windows.UI.Xaml.Controls.WebView sender, Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs args)
        {
            args.Handled = true;
            sender.Navigate(args.Uri);
        }
    }
}
