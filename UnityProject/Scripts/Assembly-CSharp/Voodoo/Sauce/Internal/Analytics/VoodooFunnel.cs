using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooFunnel
	{
		private readonly Dictionary<string, int> _stepsDict;

		public bool HasStepName(string stepName)
		{
			return false;
		}

		public int GetStepPosition(string stepName)
		{
			return 0;
		}

		public VoodooFunnel(VoodooFunnelSettings voodooFunnelSettings)
		{
		}
	}
}
