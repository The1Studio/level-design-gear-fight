using System.Collections.Generic;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class GameAnalyticsIntegrationCheck : IIntegrationCheck
	{
		private const string GANoIOSKeyError = "VoodooSauce Settings is missing iOS GameAnalytics keys";

		private const string GANoAndroidAndSecretKeyError = "VoodooSauce Settings needs both Android game and secret keys! Leave both fields empty to disable Android analytics";

		public List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}
	}
}
