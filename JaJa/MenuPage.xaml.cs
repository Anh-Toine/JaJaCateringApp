using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JaJa
{
    public partial class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void OnOrderClicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new OrderPage());
        }
    }
}
