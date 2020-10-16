using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAuth.Constants
{
	class B2CConstants
	{
		// set your tenant name, for example "contoso123tenant"
		static readonly string tenantName = "codingmastery";

		// set your tenant id, for example: "contoso123tenant.onmicrosoft.com"
		static readonly string tenantId = "codingmastery.onmicrosoft.com";

		// set your client/application id, for example: aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"
		static readonly string clientId = "3329b9f5-4693-40f6-bbe6-dd57a5103ff9";

		// set your sign up/in policy name, for example: "B2C_1_signupsignin"
		static readonly string policySignin = "B2C_1_SignUpAndSignIn";

		// set your forgot password policy, for example: "B2C_1_passwordreset"
		static readonly string policyPassword = "B2C_1_PasswordReset";

		// set to a unique value for your app, such as your bundle identifier. Used on iOS to share keychain access.
		static readonly string iosKeychainSecurityGroup = "com.xamarin.adb2cauthorization";



		// The following fields and properties should not need to be changed
		static readonly string[] scopes = { "" };
		static readonly string authorityBase = $"https://{tenantName}.b2clogin.com/tfp/{tenantId}/";
		public static string ClientId
		{
			get
			{
				return clientId;
			}
		}
		public static string AuthoritySignin
		{
			get
			{
				return $"{authorityBase}{policySignin}";
			}
		}
		public static string AuthorityPasswordReset
		{
			get
			{
				return $"{authorityBase}{policyPassword}";
			}
		}
		public static string[] Scopes
		{
			get
			{
				return scopes;
			}
		}
		public static string IosKeychainSecurityGroups
		{
			get
			{
				return iosKeychainSecurityGroup;
			}
		}
	}

	/*
	 // The /common endpoint signs in users from any AAD tenant and Microsoft Accounts
	 string multiTenanatauthority="https://login.microsoftonline.com/commom"

	// The /organizations endpoint signs in users from any AAD tenant
	 string multiTenanatauthority="https://login.microsoftonline.com/organizations"
	 
	// The /consumers endpoint signs in users from Microsoft acount only
	 string multiTenanatauthority="https://login.microsoftonline.com/consumers"
	 
	//https://login.microsoftonline.com/organizations/v2.0/adminconsent?client_id=cb370c0e-6aab-4ea3-a208-2e2441aa19df&redirect_uri=https://my-demo-mt-app-redirect-url.com/auth-response
	 */
}