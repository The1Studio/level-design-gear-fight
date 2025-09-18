using System.Collections.Generic;

namespace Voodoo.Live.Sample.Purchasing
{
	public interface IRewardsManager
	{
		bool GiveRewards(Dictionary<string, int> rewards);
	}
}
