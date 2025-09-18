using System.Collections.Generic;
using GearGame.Gameplay;
using Items;
using UnityEngine;
using Voodoo.Sauce.Internal.Analytics;

namespace GearGame.Control
{
	public class GameAnalyticsEventManager : MonoBehaviour
	{
		private static GameAnalyticsEventManager instance;

		private List<GearController> _staticGears;

		private ItemNames[] _staticGearNames;

		private string _puzzle;

		private int _extraGoldcoinGenerated;

		private HashSet<ItemNames> _coinGenerator;

		public static GameAnalyticsEventManager Instance => null;

		public static int AnalyticsTrackingValue => 0;

		public string GameMode { get; set; }

		public int PickaxeCycleCounter { get; set; }

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private string ArrayToString(IEnumerable<ItemNames> values)
		{
			return null;
		}

		private string GetStaticGearConnected()
		{
			return null;
		}

		public void RegisterStaticGears(IEnumerable<GearPeg> pegs)
		{
		}

		public void RegisterExtraCoinGenerated(int coins, ItemNames from)
		{
		}

		public void StartWave(int wave, bool isLastWave)
		{
		}

		public void LoseWave(int wave, bool isLastWave, bool wasMiniBoss)
		{
		}

		public void WinWave(int wave, bool isLastWave, bool wasMiniBoss, bool didDefeatMiniBoss)
		{
		}

		private GameFinishedParameters GenerateGameFinishedParameters(int wave, bool isLastWave, bool wasMiniBoss, bool didDefeatMiniBoss, bool didWin)
		{
			return null;
		}

		public void ShopClosedOrRerolled(int wave, string nameOne, string nameTwo, string nameThree, bool firstGearPurchased, bool secondGearPurchased, bool thirdGearPurchased, bool rerollUsed, int totalCoins, bool isPremiumShop)
		{
		}

		public void OnIAPShopOpened()
		{
		}

		public void ItemTransaction(Reward reward, TransactionLocation placement)
		{
		}

		public void ItemTransaction(IEnumerable<Reward> rewards, TransactionLocation placement)
		{
		}

		public void ItemTransaction(Item item, double nbUnit, TransactionLocation placement)
		{
		}

		public void ItemTransaction(ItemSO item, double nbUnit, TransactionLocation placement)
		{
		}

		public void ReportNIV(bool didWin, int analyticsTrackingValue, float netInvestment)
		{
		}

		public void RewardedADShown(string id)
		{
		}

		public void IAPOpportunityShown(string product_id, OfferType offerType, TransactionLocation placement, bool isRepeatOffer)
		{
		}

		public void IAPPurchased(string product_id, OfferType offerType, TransactionLocation placement, bool isRepeatOffer, int rewardDayRemaining = 0)
		{
		}

		public void IAPClaimed(string product_id, OfferType offerType, int claimDay = 1, int claimDayDelay = 0, int unclaimedDayLeft = 0)
		{
		}

		public void RewardedADCompleted(string id, string details)
		{
		}

		private Dictionary<string, object> GetQuestData(QuestSO questSo)
		{
			return null;
		}

		public void QuestRewardClaimed(string questId)
		{
		}

		public void QuestFeatureUnlocked()
		{
		}

		public void QuestCompleted(string questId, QuestGroupType questGroupType)
		{
		}

		public void QuestInitialized(string questId, QuestGroupType questGroupType)
		{
		}
	}
}
