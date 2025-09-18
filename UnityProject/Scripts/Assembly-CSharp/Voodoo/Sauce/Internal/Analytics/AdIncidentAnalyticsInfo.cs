using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public struct AdIncidentAnalyticsInfo
	{
		public string sdkName;

		public string creativeId;

		public string adUnitId;

		public string adNetwork;

		public string adFormat;

		public string blockReasons;

		public string reportReasons;
	}
}
