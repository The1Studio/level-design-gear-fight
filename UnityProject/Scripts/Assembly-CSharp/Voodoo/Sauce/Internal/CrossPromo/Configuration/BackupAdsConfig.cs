using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Configuration
{
	[Serializable]
	public class BackupAdsConfig
	{
		public bool enabled;

		public bool enabledIfNoConnection;

		public bool randomizeWaterfall;
	}
}
