using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Voodoo.Sauce.Privacy
{
	public static class PrivacyUtils
	{
		public enum GDPRType
		{
			Voodoo = 0,
			VoodooSP = 1,
			ATT = 2
		}

		private const string PopupVersion = "2.2";

		private static readonly PrivacyInfoList _analyticsSDKs;

		private static readonly PrivacyInfoList _adNetworkSDKs;

		private static bool _areSDKsInitialized;

		private static readonly Regex ValidateEmailRegex;

		public static GDPRType GetGDPRType()
		{
			return default(GDPRType);
		}

		public static string GetLocale()
		{
			return null;
		}

		public static string GetOsType()
		{
			return null;
		}

		public static string GetUserStatus()
		{
			return null;
		}

		public static string GetVSVersion()
		{
			return null;
		}

		public static string GetAppVersion()
		{
			return null;
		}

		public static string GetPopupVersion()
		{
			return null;
		}

		public static bool IsValidEmail(string email)
		{
			return false;
		}

		public static string[] GetAdNetworkNames()
		{
			return null;
		}

		public static IEnumerable<string> GetAdvertisingPrivacyPolicyUrls()
		{
			return null;
		}

		public static string[] GetAnalyticsNames()
		{
			return null;
		}

		public static IEnumerable<string> GetAnalyticsPrivacyPolicyUrls()
		{
			return null;
		}

		public static IEnumerable<string> GetPrivacyPolicyUrls()
		{
			return null;
		}

		private static void InitializePrivacyLinks()
		{
		}
	}
}
