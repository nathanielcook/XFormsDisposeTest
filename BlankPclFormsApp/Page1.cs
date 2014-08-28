using System;
using Xamarin.Forms;

namespace BlankPclFormsApp
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var customViewButton = new CustomView();
            customViewButton.Clicked += (sender, e) =>
            {
                this.Navigation.PopAsync();
            };

            var stackLayout = new StackLayout()
            {
                Padding = 20,
                Children =
                {
                    customViewButton
                }
            };

            Content = stackLayout;
        }
    }
}

