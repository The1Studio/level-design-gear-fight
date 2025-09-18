using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GearGame.SingleLoad;
using UI.Refactor.Popups;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI.Pregame
{
	public class LockedTabButtonController : MonoBehaviour
	{
		public enum OverrideLockType
		{
			CustomString = 0,
			CustomLevel = 1
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFeatureUnlockPopupAnim_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public LockedTabButtonController _003C_003E4__this;

			public FeatureUnlockedPopup popup;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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

		[SerializeField]
		private bool useLockID;

		[SerializeField]
		private int numberLevelsToUnlock;

		[SerializeField]
		private string lockID;

		[SerializeField]
		private int forceUnlockAfterNumberOfLevels;

		[SerializeField]
		private string uniqueIDForUnlockDisplay;

		[SerializeField]
		private GameObject lockedParent;

		[SerializeField]
		private GameObject unlockedParent;

		[SerializeField]
		private Button button;

		[SerializeField]
		private bool overrideLockReasonDisplay;

		[SerializeField]
		private OverrideLockType overrideLockType;

		[SerializeField]
		private string localizationKeyForLockOverride;

		[SerializeField]
		private int overrideLevel;

		[SerializeField]
		private bool _shouldShowFeatureUnlockPopup;

		[SerializeField]
		private string _featureUnlockTextLocKey;

		[SerializeField]
		private Image unlockedFeatureTargetImage;

		[SerializeField]
		private Sprite overrideUnlockedFeatureTargetSprite;

		[SerializeField]
		private List<UnityEvent> _onFeatureUnlockPopupCloseCallback;

		[SerializeField]
		private GameObject[] additionalLockItems;

		[SerializeField]
		private GameObject[] deactivateWhenLocked;

		private Transform buttonTransform;

		private EventTrigger trigger;

		private float _lastClickTime;

		private bool _didShowPopup;

		public bool LockForever { get; private set; }

		public int NumberLevelsToUnlock => 0;

		public bool ShowUnlockTypeCustomString => false;

		public bool ShowUnlockTypeCustomLevel => false;

		public string LockId => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void ItemUnlocked(WorldMetaLockManager.UnlockDetail detail)
		{
		}

		private void OnUnlockedEnd()
		{
		}

		[AsyncStateMachine(typeof(_003CFeatureUnlockPopupAnim_003Ed__41))]
		private void FeatureUnlockPopupAnim(FeatureUnlockedPopup popup)
		{
		}

		public void OnUnlocked()
		{
		}

		public void LockThisForever()
		{
		}

		public void OnPressedLocked()
		{
		}

		private void Unlock()
		{
		}
	}
}
