using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JaJa
{
    public partial class LunchPage : ContentPage
    {
        public LunchPage()
        {
            InitializeComponent();
            Type lasm = typeof(LunchPage);
            lunchImage.Source = ImageSource.FromResource("JaJa.lunch.jpeg", lasm);
        }
    }
}
