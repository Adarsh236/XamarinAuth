using Microsoft.Identity.Client;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAuth.Models;
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

			AuthenticationClient = PublicClientApplicationBuilder.Create(Constants.ClientId)
		  .WithIosKeychainSecurityGroup(Constants.IosKeychainSecurityGroups)
		  .WithB2CAuthority(Constants.AuthoritySignin)
		  .WithRedirectUri($"msal{Constants.ClientId}://auth")
		   //.WithRedirectUri("https://codingmastery.b2clogin.com/oauth2/nativeclient")
		   //.WithRedirectUri(Constants.Url)
		   .Build();

			//MainPage = new MainPage();
			MainPage = new NavigationPage(new LoginPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
