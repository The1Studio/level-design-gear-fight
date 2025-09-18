using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;
using VInspector;

namespace GearGame.SingleLoad
{
	public class WorldMetaLockManager : MonoBehaviour
	{
		[Serializable]
		public class UnlockDetail
		{
			public string Key;

			public bool IsUnlocked;

			public int UnlockLevel;
		}

		private static WorldMetaLockManager instance;

		public static readonly string CustomGearsKey;

		public static readonly string IAPShopKey;

		public static readonly string AllPacksDisplayKey;

		public static readonly string IAPStarterPackKey;

		public static readonly string IAPTroopPackKey;

		public const int AllPacksUnlockLevel = 8;

		public const int AllPacksShowLevel = 1;

		public const int AllPacksBlueCoinCost = 400;

		[SerializeField]
		private ScriptablePack associatedPackForAllPackUnlockedLegacyConversion;

		[SerializeField]
		private ScriptableGear associatedGearForCustomGearsUnlock;

		private SerializedDictionary<string, UnlockDetail> metaLockDetails;

		public static WorldMetaLockManager Instance => null;

		public event Action<UnlockDetail> OnItemUnlocked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void CreateSingleton()
		{
		}

		public void Awake()
		{
		}

		private void GearUnlockedForCustomGears(ScriptableGear obj)
		{
		}

		[Button]
		public void Unlock(string key)
		{
		}

		public bool TryGetUnlockDetail(string lockID, out UnlockDetail unlockDetail)
		{
			unlockDetail = null;
			return false;
		}

		private void Save()
		{
		}
	}
}
