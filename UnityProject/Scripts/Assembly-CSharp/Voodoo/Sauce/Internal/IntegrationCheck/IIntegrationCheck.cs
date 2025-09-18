using System.Collections.Generic;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Internal.IntegrationCheck
{
	public interface IIntegrationCheck
	{
		List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings);
	}
}
