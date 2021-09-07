using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JaJa
{
    public partial class SupperPage : ContentPage
    {
        public SupperPage()
        {
            InitializeComponent();
            Type sasm = typeof(SupperPage);
            supperImage.Source = ImageSource.FromResource("JaJa.supper.jpeg", sasm);
        }
    }
}
