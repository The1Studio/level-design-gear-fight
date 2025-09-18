using System;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class AdNetworkSDK
	{
		public string name;

		public string icon;

		public AdNetworkPlatform ios;

		public AdNetworkPlatform android;

		public string[] GetVersionsAsArray()
		{
			return null;
		}

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
