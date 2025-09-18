using System.Collections.Generic;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	[Preserve]
	public class VoodooTuneAcquisitionParameters : IVoodooTuneFilledVariables
	{
		private enum AcquisitionParameter
		{
			campaign_id = 0,
			ad_network = 1,
			creative_id = 2
		}

		public Dictionary<string, string> GetParameters()
		{
			return null;
		}

		private Dictionary<AcquisitionParameter, string> BuildAcquisitionParameters()
		{
			return null;
		}
	}
}
