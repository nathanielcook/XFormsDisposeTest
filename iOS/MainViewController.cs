using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace BlankPclFormsApp.iOS
{
    public class MainViewController : UIViewController
    {
        public MainViewController()
        {
            View.BackgroundColor = UIColor.Cyan;
            Title = "Native UIViewController test";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button = UIButton.FromType(UIButtonType.RoundedRect);
            button.Frame = new RectangleF(20, 192, 280, 30);
            button.SetTitle("push ViewController 1", UIControlState.Normal);
            View.Add(button);

            button.TouchUpInside += (sender, e) =>
            {
                var viewController1 = new ViewController1();
                this.NavigationController.PushViewController(viewController1, true);
            };

            var gcButton = UIButton.FromType(UIButtonType.RoundedRect);
            gcButton.Frame = new RectangleF(20, 350, 280, 30);
            gcButton.SetTitle("GC Collect", UIControlState.Normal);
            View.Add(gcButton);

            gcButton.TouchUpInside += (sender, e) =>
            {
                System.Diagnostics.Debug.WriteLine("Running GC.Collect()");
                GC.Collect();
            };

        }
    }
}

