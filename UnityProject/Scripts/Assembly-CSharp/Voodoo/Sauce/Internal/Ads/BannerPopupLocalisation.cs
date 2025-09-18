using System;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	[Serializable]
	public class BannerPopupLocalisation
	{
		public string language;

		public string body;

		public string purchaseButtonText;

		public string cancelButtonText;

		private static BannerPopupLocalisation _localisation;

		public static string Body => null;

		public static string PurchaseButtonText => null;

		public static string CancelButtonText => null;

		private static BannerPopupLocalisation Localisation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static BannerPopupLocalisation GetLocalisation(SystemLanguage language = SystemLanguage.Unknown)
		{
			return null;
		}
	}
}
