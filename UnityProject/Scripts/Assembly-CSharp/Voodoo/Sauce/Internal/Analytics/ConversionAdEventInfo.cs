using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class ConversionAdEventInfo : ConversionEventInfo
	{
		public int TargetNumberAdsWatched;

		public override bool IsValid()
		{
			return false;
		}
	}
}
