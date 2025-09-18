using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.UI;
using GearGame.SingleLoad;
using GearGame.Tutorials;
using GearGame.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Control
{
	public class TroopPackCanvasController : MonoBehaviour
	{
		public enum AllPacksButtonState
		{
			Locked = 0,
			PurchaseableNoAfford = 1,
			PurchaseableYesAfford = 2,
			Unlocked = 3
		}

		[CompilerGenerated]
		private sealed class _003CDelayRebuild_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopPackCanvasController _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayRebuild_003Ed__45(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private TextMeshProUGUI[] packTitleTexts;

		[SerializeField]
		private TextMeshProUGUI[] rankTexts;

		[SerializeField]
		private string rankLocalizationString;

		[SerializeField]
		private Transform troopLayoutTransform;

		[SerializeField]
		private GameObject yesUpgradeButton;

		[SerializeField]
		private GameObject packWeakButton;

		[SerializeField]
		private GameObject allPacksRoot;

		[SerializeField]
		private GameObject allPacksLockRoot;

		[SerializeField]
		private GameObject gearsLockedRoot;

		[SerializeField]
		private Transform gearLoadoutSpawnTransform;

		[SerializeField]
		private PackSpecificIndividualGearDisplay gearDisplayPrefab;

		[SerializeField]
		private TroopRootCanvas troopRootCanvas;

		[SerializeField]
		private ShowHideGearsController showHideGearsController;

		[SerializeField]
		private CurrencySO gemCurrency;

		[SerializeField]
		private UnlockPackTutorial packTutorial;

		[SerializeField]
		private Button allPacksButton;

		[SerializeField]
		private GameObject allPacksHidden;

		[SerializeField]
		private GameObject allPacksUnlocked;

		[SerializeField]
		private GameObject allPacksPurchaseable;

		[SerializeField]
		private GameObject purchaseablePackYesAfford;

		[SerializeField]
		private GameObject purchaseablePackNoAfford;

		[SerializeField]
		private TextMeshProUGUI unlockCostText;

		private List<UpgradeableTroopUIController> upgradeableTroops;

		private List<PackSpecificIndividualGearDisplay> allGearDisplays;

		private ScriptablePack pack;

		private AllPacksButtonState allPacksButtonState;

		private ScriptablePack lastGeneratedGearSection;

		public AllPacksButtonState CurrentPackState => default(AllPacksButtonState);

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void AllPacksButtonPressed()
		{
		}

		private void ItemUnlocked(WorldMetaLockManager.UnlockDetail detail)
		{
		}

		private void Unsubscribe()
		{
		}

		public void Initialize(ScriptablePack pack)
		{
		}

		public void OnPackUpgradeButtonPressed()
		{
		}

		private void RefreshGearPackDisplay()
		{
		}

		private void GemValueChanged(double value)
		{
		}

		private void RefreshXPCheck(ScriptablePack _, int xp)
		{
		}

		private void RefreshUpgradeStatus()
		{
		}

		private void RefreshRank(ScriptablePack _, int level)
		{
		}

		private bool IsGearSectionUnlocked()
		{
			return false;
		}

		private void TryUnlockGearsSection()
		{
		}

		private void RevealGearSection()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayRebuild_003Ed__45))]
		private IEnumerator DelayRebuild()
		{
			return null;
		}

		private void SpawnDisplayGears()
		{
		}
	}
}
