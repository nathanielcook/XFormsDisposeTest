using System;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using System.Drawing;
using BlankPclFormsApp;
using BlankPclFormsApp.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomViewRenderer))]

namespace BlankPclFormsApp.iOS
{
    public class CustomViewRenderer : ViewRenderer<CustomView, CustomButton>
    {
        public CustomViewRenderer()
        {
            this.BackgroundColor = UIColor.Red;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var control = new CustomButton();
                control.Frame = new RectangleF(20, 192, 280, 30);
                control.SetTitle("pop page 1", UIControlState.Normal);

                control.TouchUpInside += (sender, eventArgs) =>
                {
                    this.BackgroundColor = UIColor.Orange;

                    var button = e.NewElement;
                    if (button != null)
                        button.SendClicked();
                };

                SetNativeControl(control);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            System.Diagnostics.Debug.WriteLine("CustomViewRenderer is being disposed.");
        }
    }
}
