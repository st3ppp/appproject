using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Maraes.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
			NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
		}
    }
}
