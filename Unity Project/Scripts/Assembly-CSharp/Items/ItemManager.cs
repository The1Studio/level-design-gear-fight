using System;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
	public class ItemManager : MonoBehaviour
	{
		private static ItemManager _instance;

		[SerializeField]
		private ItemManagerSO _settings;

		private Dictionary<ItemNames, ItemSO> _itemDictionnary;

		private Dictionary<Type, ItemSystem> _systems;

		private Dictionary<ItemNames, Payoutable> _payouts;

		private bool _recordRewards;

		private List<Reward> _rewards;

		public ItemSO this[ItemNames id] => null;

		public static ItemManagerSO Settings => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Initialize()
		{
		}

		private void LoadSave()
		{
		}

		private void SaveRecords()
		{
		}

		private IEnumerable<Reward> ClaimInternal(ItemSO item, double amount, RaritySO rarity, bool record)
		{
			return null;
		}

		public static IEnumerable<T> GetItemsOfType<T>() where T : ItemSO
		{
			return null;
		}

		public static ItemSO Get(ItemNames id)
		{
			return null;
		}

		public static T Get<T>(ItemNames id) where T : ItemSO
		{
			return null;
		}

		public static List<Reward> MultiplyRewards(List<Reward> rewards, float multiplier)
		{
			return null;
		}

		public static void StartRecordingRewards()
		{
		}

		public static void StopRecordingRewards()
		{
		}

		public static List<Reward> NormalizeRewards(IEnumerable<Reward> rewards)
		{
			return null;
		}

		public static List<Reward> GetRecordedRewards()
		{
			return null;
		}

		public static IEnumerable<Reward> Claim(ItemSO item, double amount, RaritySO rarity, bool record, TransactionLocation transactionLocation)
		{
			return null;
		}

		public static IEnumerable<Reward> Claim(ItemSO item, double amount, RaritySO rarity, TransactionLocation transactionLocation)
		{
			return null;
		}

		public static IEnumerable<Reward> Claim(ItemSO item, double amount, TransactionLocation transactionLocation)
		{
			return null;
		}

		public static void RegisterPayoutable(ItemNames item, Payoutable payoutable)
		{
		}

		public static void UnregisterPayoutable(ItemNames item)
		{
		}

		public static double GetPayout(ItemNames item, int level, float percentage = 1f)
		{
			return 0.0;
		}

		public static double GetPayout(ItemNames item, float percentage = 1f)
		{
			return 0.0;
		}

		public static void OnDataReloaded()
		{
		}

		public static void CancelItemsAnimation()
		{
		}

		public static void SetItemsAnimationtTimeScale(float timeScale)
		{
		}
	}
}
