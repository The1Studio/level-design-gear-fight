using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury.Parameters
{
	[Serializable]
	public struct GetGameInfoParameters
	{
		public string bundleId;

		public string cpFormat;

		public string idfv;

		public string osType;

		public string adId;

		public string waterfallGameList;

		public string waterfallId;

		public string userId;

		public string sessionId;

		public int sessionCount;

		public int appOpenCount;

		public int userGameCount;

		public string manufacturer;

		public string deviceModel;

		public string screenResolution;

		public string appVersion;

		public string gameWinRatio;

		public bool restrictedPrivacy;

		public string ToJsonString()
		{
			return null;
		}
	}
}
