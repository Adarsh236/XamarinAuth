using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAuth.Models
{
	public static class Constants
	{

		//public const string ApplicationID = "3329b9f5-4693-40f6-bbe6-dd57a5103ff9";

		/*public const string IosKeychainSecurityGroups = "B2C_1_passwordreset";
		public const string AuthoritySignin = "B2C_1_passwordreset";
		public const string Scopes = "msalxamarinauth://auth";
		public const string AuthorityPasswordReset = "B2C_1_passwordreset";*/

		/*static readonly string tenantName = "codingmaster";
		static readonly string tenantId = "262885db-2921-481d-b4ad-f61b0b859144";
		static readonly string applicationID = "3329b9f5-4693-40f6-bbe6-dd57a5103ff9";
		static readonly string url = "msalxamarinauth://auth";
		static readonly string policySignin = "B2C_1_SignUpAndSignIn";
		static readonly string policyPassword = "B2C_1_PasswordReset";*/

		//app 2

		/*static readonly string tenantName = "codingmastery";
		//static readonly string tenantId = "262885db-2921-481d-b4ad-f61b0b859144";
		static readonly string tenantId = "codingmastery.onmicrosoft.com";
		static readonly string applicationID = "3329b9f5-4693-40f6-bbe6-dd57a5103ff9";
		static readonly string url = "msalxamarinauth://auth";
		static readonly string policySignin = "B2C_1_SignUpAndSignIn";
		static readonly string policyPassword = "B2C_1_PasswordReset";

		// set to a unique value for your app, such as your bundle identifier. Used on iOS to share keychain access.
		static readonly string iosKeychainSecurityGroup = "com.xamarin.adb2cauthorization";

		// The following fields and properties should not need to be changed
		static readonly string[] scopes = { "" };
		static readonly string authorityBase = $"https://{tenantName}.b2clogin.com/tfp/{tenantId}/";
		//static readonly string authorityBase = $"https://codingmastery.b2clogin.com/tfp/oauth2/nativeclient";*/
		static readonly string tenantName = "codingmastery";
		static readonly string tenantId = "codingmastery.onmicrosoft.com";
		static readonly string clientId = "3329b9f5-4693-40f6-bbe6-dd57a5103ff9";
		static readonly string issuerID = "https://<domain>/tfp/262885db-2921-481d-b4ad-f61b0b859144/B2C_1_SignUpAndSignIn/v2.0/";
		static readonly string url = "msalxamarinauth://auth";
		static readonly string policySignin = "B2C_1_SignUpAndSignIn";
		static readonly string policyPassword = "B2C_1_PasswordReset";

		// set to a unique value for your app, such as your bundle identifier. Used on iOS to share keychain access.
		static readonly string iosKeychainSecurityGroup = "com.xamarin.adb2cauthorization";

		// The following fields and properties should not need to be changed
		static readonly string[] scopes = { "" };
		static readonly string authorityBase = $"https://{tenantName}.b2clogin.com/tfp/{tenantId}/";
		//static readonly string authorityBase = $"https://codingmastery.b2clogin.com/tfp/oauth2/nativeclient";

		public static string Url
		{
			get
			{
				return url;
			}
		}
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
}
