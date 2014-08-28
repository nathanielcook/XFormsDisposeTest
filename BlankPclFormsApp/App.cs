using System;
using Xamarin.Forms;

namespace BlankPclFormsApp
{
    public class App
    {
        public static Page RootPage;

        public static Page GetMainPage()
        {	
            RootPage = new NavigationPage(new MainPage());
            return RootPage;
        }
    }
}

