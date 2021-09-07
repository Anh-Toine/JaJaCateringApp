using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JaJa
{
    public partial class BreakfastPage : ContentPage
    {
        public BreakfastPage()
        {
            InitializeComponent();

            Type basm = typeof(BreakfastPage);
            breakfastImage.Source = ImageSource.FromResource("JaJa.breakfast.jpeg",basm);
        }
    }
}
