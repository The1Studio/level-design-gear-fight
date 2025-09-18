using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class VoodooFunnelsSettings
	{
		public VoodooFunnelSettings[] funnels;

		public VoodooFunnelsSettings DeepCopy()
		{
			return null;
		}
	}
}
