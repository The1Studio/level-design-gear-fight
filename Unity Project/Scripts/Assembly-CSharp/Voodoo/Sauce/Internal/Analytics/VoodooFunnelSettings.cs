using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class VoodooFunnelSettings
	{
		public string name;

		public VoodooFunnelStepSettings[] steps;
	}
}
