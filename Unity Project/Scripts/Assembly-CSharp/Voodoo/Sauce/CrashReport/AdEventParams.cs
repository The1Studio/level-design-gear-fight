using System.Collections.Generic;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.CrashReport
{
	public class AdEventParams
	{
		public enum AdEventName
		{
			banner_shown = 0,
			fs_shown = 1,
			ao_shown = 2,
			rv_shown = 3,
			audio_ad_shown = 4,
			thumbnail_shown = 5,
			native_shown = 6,
			fs_watched = 7,
			ao_watched = 8,
			rv_watched = 9,
			native_closed = 10
		}

		private string Network;

		private string AdType;

		private string Creative;

		private string ImpressionId;

		public AdEventParams(string network, string adType, string creative, string impressionId)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}

		public static AdEventParams FromAnalyticsInfo(AdAnalyticsInfo adAnalyticsInfo)
		{
			return null;
		}
	}
}
