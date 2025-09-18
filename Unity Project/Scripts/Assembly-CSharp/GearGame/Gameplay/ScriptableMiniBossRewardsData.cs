using System;
using Items;
using UnityEngine;

namespace GearGame.Gameplay
{
	[CreateAssetMenu(menuName = "Gameplay/Mini Boss/Reward Data", order = 0)]
	public class ScriptableMiniBossRewardsData : ScriptableObject
	{
		public enum RewardType
		{
			BlueCoins = 0,
			GreenCoins = 1,
			Diamonds = 2,
			MiniGears = 3
		}

		public abstract class Reward : ScriptableObject
		{
			[field: SerializeField]
			public GameObject RewardPrefab { get; private set; }

			public abstract string LocalizationString { get; }

			public abstract string GetPayoutString();

			public abstract double GetPayout();

			public abstract bool IsValid();

			public abstract void Payout(Vector3 position, TransactionLocation location);

			public abstract Sprite GetIcon();
		}

		[Serializable]
		public class RewardBundle
		{
			[field: SerializeField]
			public float Weight { get; private set; }

			[field: SerializeField]
			public Reward[] AllRewards { get; private set; }

			public static implicit operator Tuple<float, Reward[]>(RewardBundle bundle)
			{
				return null;
			}
		}

		[SerializeField]
		private RewardBundle[] allBundles;

		[SerializeField]
		private RewardBundle[] singleShownForcedStructureBundles;

		private void TryInitialize()
		{
		}

		public Reward[] GetRewardBundle(bool isChest)
		{
			return null;
		}

		public void IncrementBundleOn(bool isChest)
		{
		}
	}
}
