using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class MediationSDK : SDK
	{
		public List<AdNetworkSDK> adNetworks;

		public List<SDK> otherUtilitySdk;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
