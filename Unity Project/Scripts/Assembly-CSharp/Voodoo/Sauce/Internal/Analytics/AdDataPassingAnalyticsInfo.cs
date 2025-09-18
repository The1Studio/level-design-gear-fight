using System;
using Voodoo.Sauce.Ads.AdDataPassing;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public struct AdDataPassingAnalyticsInfo
	{
		public bool statusSucceed;

		public GenderType gender;

		public float randomness;
	}
}
