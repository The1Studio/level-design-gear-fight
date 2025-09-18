using System;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class AdNetworkPlatform
	{
		public string version;

		public bool certified;

		public Adapter adapter;

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
