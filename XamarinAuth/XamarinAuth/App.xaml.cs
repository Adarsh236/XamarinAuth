using Microsoft.Identity.Client;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAuth.Constants;
using XamarinAuth.Models;
using XamarinAuth.Pages;
using XamarinAuth.Views;

namespace XamarinAuth
{
	public partial class App : Application
	{
		public static IPublicClientApplication AuthenticationClient { get; private set; }

		public static object UIParent { get; set; } = null;

		public App()
		{
			InitializeComponent();

			AuthenticationClient = PublicClientApplicationBuilder.Create(B2CConstants.ClientId)
				.WithIosKeychainSecurityGroup(B2CConstants.IosKeychainSecurityGroups)
				.WithB2CAuthority(B2CConstants.AuthoritySignin)
				.WithRedirectUri($"msal{B2CConstants.ClientId}://auth")
				.Build();

			MainPage = new NavigationPage(new LoginPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}

}
