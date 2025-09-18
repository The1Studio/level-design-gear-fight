using System.Collections.Generic;

namespace Items
{
	public delegate IEnumerable<Reward> ClaimProcessor(ItemSO item, int amount, RaritySO rarity);
}
