using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580073A
{
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();
            backButton.Clicked += BackButton_Clicked;
            //backToRootButton += 
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
