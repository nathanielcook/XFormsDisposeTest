using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace BlankPclFormsApp.iOS
{
    [Register("CustomButton")]
    public class CustomButton : UIButton
    {
        public CustomButton()
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            System.Diagnostics.Debug.WriteLine("CustomButton (which inherits from UIButton) is being disposed.");
        }
    }
}

