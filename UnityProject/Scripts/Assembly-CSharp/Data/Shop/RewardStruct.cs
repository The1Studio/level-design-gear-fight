using System;
using GearGame.Control;
using GearGame.Gameplay;
using GearGame.UI;
using Items;
using UnityEngine;

namespace Data.Shop
{
	[Serializable]
	public struct RewardStruct
	{
		public enum Type
		{
			Currency = 0,
			MiniGears = 1,
			PayoutableCurrency = 2,
			GlobalGameplayBoost = 3,
			TroopLevels = 4,
			Pack = 5
		}

		public Type RewardType;

		public double Amount;

		public CurrencySO Currency;

		public ScriptableMiniBossRewardsData.Reward Reward;

		public ScriptablePack PackReward;

		public int OverridePackLevel;

		public bool UnlockAllPackCharacters;

		public PackOpeningCanvasController.ChestDisplay chestDisplay;

		public bool SpecificMiniGears;

		public ScriptableGear[] SpecifcGears;

		public ScriptableGlobalGameplayBoostData GlobalGameplayBoost;

		public bool ShouldBurstCurrency;

		private readonly bool DoHideAmount => false;

		public void GiveReward(Transform buttonTransform, TransactionLocation transactionLocation)
		{
		}

		public string GetDescription()
		{
			return null;
		}

		public double GetAmount()
		{
			return 0.0;
		}

		public string GetShortDescription()
		{
			return null;
		}

		public Sprite GetIcon()
		{
			return null;
		}
	}
}
