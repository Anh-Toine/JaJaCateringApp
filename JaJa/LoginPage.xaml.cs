using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JaJa
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
            if(isEmailEmpty || isPasswordEmpty)
            {
                await DisplayAlert("Alert","Please double check your input","OK");
            }
            else
            {
                await Navigation.PushAsync(new MenuPage());
            }
        }
    }
}
