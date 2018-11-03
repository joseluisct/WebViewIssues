using System;
using WebViewIssues;
using WebViewIssues.macOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace WebViewIssues.macOS
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.UIRunJavaScriptAlertPanelMessage += Control_UIRunJavaScriptAlertPanelMessage;
            }
        }

        private void Control_UIRunJavaScriptAlertPanelMessage(object sender, WebKit.WebViewJavaScriptFrameEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Alert received: " + e.WithMessage);
        }

        /*[Export("webView:decidePolicyForNavigationAction:request:frame:decisionListener:")]
        public void DecidePolicyForNavigation(WebKit.WebView webView, NSDictionary actionInformation, NSUrlRequest request, WebKit.WebFrame frame, WebKit.IWebPolicyDecisionListener decisionToken)
        {
            System.Diagnostics.Debug.WriteLine("Navigating to URL: " + request.Url.AbsoluteString);

            if (!request.Url.AbsoluteString.StartsWith("file:///"))
            {
                var cancel = true;
                if (!cancel) decisionToken.Use();
            }
            //base.DecidePolicyForNavigation(webView, actionInformation, request, frame, decisionToken);
        }*/
    }
}
