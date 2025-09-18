using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class SDKList
	{
		public string vsVersion;

		public string lastUpdateDate;

		public List<MediationSDK> ads;

		public List<SDK> analytics;

		public List<SDK> crashlytics;

		public List<SDK> audioAds;

		public List<SDK> consentManagementProvider;

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
