using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAuth.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogoutPage : ContentPage
	{
		public LogoutPage(AuthenticationResult result)
		{
			InitializeComponent();
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			IEnumerable<IAccount> accounts = await App.AuthenticationClient.GetAccountsAsync();

			while (accounts.Any())
			{
				await App.AuthenticationClient.RemoveAsync(accounts.First());
				accounts = await App.AuthenticationClient.GetAccountsAsync();
			}

			await Navigation.PopAsync();
		}
	}
}