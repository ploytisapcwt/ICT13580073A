using System;

using Xamarin.Forms;

namespace ICT13580073A
{
    public class TabPage1 : ContentPage
    {
        public TabPage1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

