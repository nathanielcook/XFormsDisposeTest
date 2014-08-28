using System;
using Xamarin.Forms;
using BlankPclFormsApp;
using BlankPclFormsApp.iOS;
using Xamarin.Forms.Platform.iOS;
using System.Drawing;
using MonoTouch.UIKit;

[assembly: ExportRenderer(typeof(Page2), typeof(Page2Renderer))]

namespace BlankPclFormsApp.iOS
{
    public class Page2Renderer : PageRenderer
    {
        public Page2Renderer()
        {
            System.Diagnostics.Debug.WriteLine("Page2 has been instantiated.");           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.Purple;

            var button = new CustomButton();
            button.Frame = new RectangleF(20, 192, 280, 30);
            button.SetTitle("pop page 2", UIControlState.Normal);
            View.Add(button);

            button.TouchUpInside += (sender, e) =>
            {
                this.View.BackgroundColor = UIColor.Green;                

                //both of these seem to work fine
                //this.NavigationController.PopViewControllerAnimated(true);
                App.RootPage.Navigation.PopAsync();
            };
        }

        protected override void Dispose(bool disposing)
        {
            System.Diagnostics.Debug.WriteLine("Page2 has been disposed");           
            base.Dispose(disposing);
        }
    }
}

