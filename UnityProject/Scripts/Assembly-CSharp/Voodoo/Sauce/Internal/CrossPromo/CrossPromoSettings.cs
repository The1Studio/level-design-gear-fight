using System;

namespace Voodoo.Sauce.Internal.CrossPromo
{
	[Serializable]
	public class CrossPromoSettings
	{
		public const string BaseUrl = "https://crosspromo.voodoo.io/api";

		public const string Token = "Token 16aaae9ea829470dc2993d0afe865d1165230589";

		public static bool IsCrossPromoEnabled()
		{
			return false;
		}
	}
}
