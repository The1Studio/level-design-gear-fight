using JetBrains.Annotations;
using Voodoo.Sauce.Ads;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class AdAnalyticsInfo
	{
		[CanBeNull]
		public string WaterfallTestName;

		[CanBeNull]
		public string WaterfallName;

		[CanBeNull]
		public string AdTag;

		public int? AdLoadingTime;

		[CanBeNull]
		public string AdNetworkName;

		[CanBeNull]
		public string Creative;

		public bool? IsFsShownInsteadOfRv;

		[CanBeNull]
		public string ReasonFsShownInsteadOfRv;

		[CanBeNull]
		public string ImpressionId;

		public RewardPopUpType RewardFsType;
	}
}
