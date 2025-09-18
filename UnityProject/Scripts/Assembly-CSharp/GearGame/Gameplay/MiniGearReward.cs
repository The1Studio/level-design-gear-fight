using GearGame.Control;
using Items;
using UnityEngine;

namespace GearGame.Gameplay
{
	[CreateAssetMenu(menuName = "Gameplay/Mini Boss/Mini Gears Reward")]
	public class MiniGearReward : ScriptableMiniBossRewardsData.Reward
	{
		[field: SerializeField]
		public int NumberOfGears { get; private set; }

		[field: SerializeField]
		public ScriptableGear[] ForcedGears { get; private set; }

		public override string LocalizationString => null;

		public override double GetPayout()
		{
			return 0.0;
		}

		public override string GetPayoutString()
		{
			return null;
		}

		public override bool IsValid()
		{
			return false;
		}

		public override void Payout(Vector3 position, TransactionLocation transactionLocation)
		{
		}

		public override Sprite GetIcon()
		{
			return null;
		}
	}
}
