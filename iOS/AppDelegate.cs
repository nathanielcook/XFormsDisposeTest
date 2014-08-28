using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;

namespace BlankPclFormsApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            window = new UIWindow(UIScreen.MainScreen.Bounds);
			
            //SWITCH the following two lines to change between Xamarin forms and native iOS UIViewControllers
            //window.RootViewController = App.GetMainPage().CreateViewController();
            window.RootViewController = new UINavigationController(new MainViewController());

            window.MakeKeyAndVisible();
			
            return true;
        }
    }
}

