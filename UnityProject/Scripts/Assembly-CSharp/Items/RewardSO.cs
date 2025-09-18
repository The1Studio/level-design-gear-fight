using System.Collections.Generic;
using UnityEngine;

namespace Items
{
	[CreateAssetMenu(menuName = "Items/Rewards")]
	public class RewardSO : ItemSO
	{
		public Color Color;

		[SerializeReference]
		public BaseDrop[] Rewards;

		public List<DropInfos> GetPossibleRewards(DropRange amount, float percentage)
		{
			return null;
		}

		public List<DropInfos> GetPossibleRewards(int amount = 1, float percentage = 100f)
		{
			return null;
		}
	}
}
