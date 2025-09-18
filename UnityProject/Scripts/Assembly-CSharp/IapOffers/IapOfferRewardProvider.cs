using Data.Shop;
using GearGame.Control;
using Items;
using Sirenix.OdinInspector;
using UnityEngine;

namespace IapOffers
{
	public class IapOfferRewardProvider : SerializedMonoBehaviour
	{
		private static IapOfferRewardProvider _instance;

		[SerializeField]
		private RewardStruct[][] _standardRewards;

		[SerializeField]
		private RewardStruct[][] _premiumRewards;

		[SerializeField]
		private RewardStruct[][] _troopRewards;

		[SerializeField]
		private RewardStruct[][] _troopRewardsSingleDay;

		[SerializeField]
		private ScriptablePack _plantPack;

		public static ScriptablePack PlantPack => null;

		private void Awake()
		{
		}

		public static RewardStruct[] GetRewards(OfferType offerType, int index)
		{
			return null;
		}
	}
}
