using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAuth.Constants;
using XamarinAuth.Models;

namespace XamarinAuth.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			try
			{
				// Look for existing account
				IEnumerable<IAccount> accounts = await App.AuthenticationClient.GetAccountsAsync();

				AuthenticationResult result = await App.AuthenticationClient
					.AcquireTokenSilent(B2CConstants.Scopes,
						 accounts.FirstOrDefault())
					.ExecuteAsync();

				Trace.WriteLine("OnAppearing-------------------------");
				//Trace.WriteLine(accounts.ToString());
				//Trace.WriteLine(B2CConstants.Scopes);
				Trace.WriteLine(result);


				Trace.WriteLine("OnAppearing-------------------------End");


				await Navigation.PushAsync(new LogoutPage(result));
			}
			catch
			{
				// Do nothing - the user isn't logged in
			}
			base.OnAppearing();
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			AuthenticationResult result;
			try
			{
				result = await App.AuthenticationClient
					.AcquireTokenInteractive(B2CConstants.Scopes)
					.WithPrompt(Prompt.SelectAccount)
					.WithParentActivityOrWindow(App.UIParent)
					.ExecuteAsync();

				Trace.WriteLine("OnLoginButtonClicked-------------------------");
				//Trace.WriteLine(B2CConstants.Scopes);
				Trace.WriteLine(result);


				Trace.WriteLine("OnLoginButtonClicked-------------------------End");

				await Navigation.PushAsync(new LogoutPage(result));
			}
			catch (MsalException ex)
			{
				if (ex.Message != null && ex.Message.Contains("AADB2C90118"))
				{
					result = await OnForgotPassword();
					await Navigation.PushAsync(new LogoutPage(result));
				}
				else if (ex.ErrorCode != "authentication_canceled")
				{
					await DisplayAlert("An error has occurred", "Exception message: " + ex.Message, "Dismiss");
				}
			}
		}
		async Task<AuthenticationResult> OnForgotPassword()
		{
			try
			{
				return await App.AuthenticationClient
					.AcquireTokenInteractive(B2CConstants.Scopes)
					.WithPrompt(Prompt.SelectAccount)
					.WithParentActivityOrWindow(App.UIParent)
					.WithB2CAuthority(B2CConstants.AuthorityPasswordReset)
					.ExecuteAsync();
			}
			catch (MsalException)
			{
				// Do nothing - ErrorCode will be displayed in OnLoginButtonClicked
				return null;
			}
		}
	}
}