using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GearGame.Advertising;
using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class PurchaseShopController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClose_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PurchaseShopController _003C_003E4__this;

			private Task<bool> _003Ctask_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static readonly List<ScriptableGear> ForcedRVGears;

		public static int ForcedPremiumIndex;

		[SerializeField]
		private bool isPremiumShop;

		[SerializeField]
		private GameObject storeRoot;

		[SerializeField]
		private RewardedADButtonController collectAllRewardedADButton;

		[SerializeField]
		private GameObject rerollButton;

		[SerializeField]
		private Animator entranceAnimator;

		[SerializeField]
		private GearStoreSlot[] allSlots;

		[SerializeField]
		private ScriptableGear premiumIncomeGear;

		[SerializeField]
		private GameObject buttonRoot;

		[SerializeField]
		private WarningCanvasController warningCanvasController;

		[SerializeField]
		private GameObject purchaseOnRoot;

		[SerializeField]
		private GameObject purchaseOffRoot;

		[SerializeField]
		private TextMeshProUGUI rerollCostText;

		[SerializeField]
		private int rerollCost;

		[SerializeField]
		private ScriptableSkill freeReroll;

		private readonly List<ScriptableGear> deckList;

		private int levelOffset;

		private int freeRerolls;

		private int currentRerollCost;

		private int lastFightGetBestGearFightShown;

		private int lastFightGetAllGearsFightShown;

		private bool hasInitialized;

		private string nameOne;

		private string nameTwo;

		private string nameThree;

		private Action _startFightCallback;

		public bool MergeIncrement { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetButtonRootStatus(bool status)
		{
		}

		public GearController[] GetCurrentGearsInSlots()
		{
			return null;
		}

		private void GearChanged(GearStoreSlot _)
		{
		}

		private void OnCollectAllFinished(bool status)
		{
		}

		private void Initialize()
		{
		}

		private void GetGears()
		{
		}

		private void CoinsChanged(float val)
		{
		}

		private void CollectNextLevelGears()
		{
		}

		private bool IsPremiumShopAndCanShowGemOffer()
		{
			return false;
		}

		private void GenerateGears()
		{
		}

		private bool HasEnoughSpaceOnGrid(int amount)
		{
			return false;
		}

		private void CheckForSpecialCoinGear()
		{
		}

		private void GenerateGear(GearStoreSlot slot)
		{
		}

		public void TryReroll()
		{
		}

		public void ForceReroll()
		{
		}

		private void TryDiscardSlot(GearStoreSlot slot)
		{
		}

		public void Open(Action startFightCallback)
		{
		}

		private string TryGetGearDisplayName(GearStoreSlot slot)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClose_003Ed__51))]
		public void Close()
		{
		}
	}
}
