using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Maraes.Views
{
    public partial class CustomNavigationPage : NavigationPage
    {
		public CustomNavigationPage() : base()
		{
			InitializeComponent();
		}

		public CustomNavigationPage(Page root) : base(root)
		{
			InitializeComponent();
		}
    }
}
