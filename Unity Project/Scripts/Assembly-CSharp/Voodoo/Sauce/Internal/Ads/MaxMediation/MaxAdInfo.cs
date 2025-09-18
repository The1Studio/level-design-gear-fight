using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Ads.MaxMediation
{
	internal class MaxAdInfo
	{
		internal MaxSdkBase.AdInfo MaxNativeAdInfo { get; private set; }

		[CanBeNull]
		internal string WaterfallTestName { get; private set; }

		[CanBeNull]
		internal string WaterfallName { get; private set; }

		internal MaxAdInfo(MaxSdkBase.AdInfo maxNativeInfo)
		{
		}

		internal void Update(MaxSdkBase.AdInfo maxNativeInfo)
		{
		}
	}
}
