using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Foundation;
using Maraes.Services;
using Maraes.Services.Interfaces;
using Maraes.ViewModels.Base;
using UIKit;
using FFImageLoading.Forms.Touch;

namespace Maraes.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Initialize Azure Mobile Apps
			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

			// Initialize Xamarin Forms
			global::Xamarin.Forms.Forms.Init ();
			CachedImageRenderer.Init();

            ViewModelLocator.Instance.RegisterSingleton<INavigationService, iOSNavigationService>();

            LoadApplication(new App());

			return base.FinishedLaunching (application, launchOptions);
		}
	}
}

