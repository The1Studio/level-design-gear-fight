using System;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class Adapter
	{
		public string version;

		public AdFormat banner;

		public AdFormat interstitial;

		public AdFormat rewardedVideo;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool IsEmpty()
		{
			return false;
		}
	}
}
