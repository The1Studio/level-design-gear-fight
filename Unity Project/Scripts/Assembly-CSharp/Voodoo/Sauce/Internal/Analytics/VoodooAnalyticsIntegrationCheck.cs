using System.Collections.Generic;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooAnalyticsIntegrationCheck : IIntegrationCheck
	{
		private const string SETTINGS_VOODOO_ANALYTICS_AB_TESTING_DEACTIVATED_ERROR = "VoodooAnalytics must be activated via VoodooKitchen for RemoteConfig AB Tests to work. Please contact Voodoo if you believe this is a mistake.";

		public List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}
	}
}
