using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace BlankPclFormsApp.iOS
{
    public class ViewController1 : UIViewController
    {
        public ViewController1()
        {
            System.Diagnostics.Debug.WriteLine("ViewController1 has been instantiated.");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //SWITCH the following two lines to change between a standard control and a custom one that inherits from NSObject
            var button = new UIButton();
            //var button = new CustomButton();

            button.Frame = new RectangleF(20, 192, 280, 30);
            button.SetTitle("pop ViewController1", UIControlState.Normal);
            View.Add(button);

            button.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PopViewControllerAnimated(true);
            };
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            System.Diagnostics.Debug.WriteLine("ViewController1 has been disposed.");
        }
    }
}
    