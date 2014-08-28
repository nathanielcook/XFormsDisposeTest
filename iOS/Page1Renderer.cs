using System;
using Xamarin.Forms;
using BlankPclFormsApp;
using BlankPclFormsApp.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Page1), typeof(Page1Renderer))]

namespace BlankPclFormsApp.iOS
{
    public class Page1Renderer : PageRenderer
    {
        public Page1Renderer()
        {
            System.Diagnostics.Debug.WriteLine("Page1 has been instantiated.");           
        }

        protected override void Dispose(bool disposing)
        {
            System.Diagnostics.Debug.WriteLine("Page1 has been disposed.");           
            base.Dispose(disposing);
        }
    }
}

