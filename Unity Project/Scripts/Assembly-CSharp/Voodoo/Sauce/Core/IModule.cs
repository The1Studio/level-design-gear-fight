using System.Collections.Generic;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.Core
{
	public interface IModule
	{
		List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings);
	}
}
