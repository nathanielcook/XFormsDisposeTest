using System;
using Xamarin.Forms;

namespace BlankPclFormsApp
{
    public class CustomView : View
    {
        public event EventHandler Clicked;

        public void SendClicked()
        {
            var handler = Clicked;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}

