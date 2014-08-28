using System;
using Xamarin.Forms;

namespace BlankPclFormsApp
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Xamarin Forms pages test";

            var page1Button = new Button { Text = "push page 1" };

            page1Button.Clicked += (sender, e) =>
            {                
                var page1 = new Page1();
                this.Navigation.PushAsync(page1);
            };

            var page2Button = new Button { Text = "push page 2" };

            page2Button.Clicked += (sender, e) =>
            {                
                var page2 = new Page2();
                this.Navigation.PushAsync(page2);
            };

            var gcButton = new Button { Text = "GC Collect" };

            gcButton.Clicked += (sender, e) =>
            {            
                System.Diagnostics.Debug.WriteLine("Running GC.Collect()");
                GC.Collect();
            };

            var stackLayout = new StackLayout()
            {
                Padding = 20,
                Spacing = 40,
                Children =
                {
                    page1Button,
                    page2Button,
                    gcButton
                }
            };

            Content = stackLayout;
        }
    }
}
    