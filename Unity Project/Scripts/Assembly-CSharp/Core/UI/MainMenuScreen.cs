using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using GearGame.Control;
using GearGame.Gameplay;
using GearGame.Gameplay.UI.Pregame;
using GearGame.Managers.SingleLoad;
using UnityEngine;
using VInspector;

namespace Core.UI
{
	public class MainMenuScreen : Screen
	{
		public enum Tab
		{
			Root = 0,
			Skill = 1,
			Team = 2,
			Boss = 3,
			TrickleGear = 4,
			CustomGears = 5,
			IAPShop = 6,
			Quests = 7,
			Blessings = 8
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public ChapterRewardsManager.ChapterReward pendingRewards;

			internal void _003CDelayStart_003Eb__0(ChapterRewardsPopupController popup)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDelayPayout_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MainMenuScreen _003C_003E4__this;

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
			public _003CDelayPayout_003Ed__21(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDelayStart_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MainMenuScreen _003C_003E4__this;

			private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

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
			public _003CDelayStart_003Ed__23(int _003C_003E1__state)
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
		private SerializedDictionary<Tab, PreGameTabController> allTabs;

		[SerializeField]
		private CurrencySO blueCoinsCurrency;

		[SerializeField]
		private CurrencySO greenCoinsCurrency;

		[SerializeField]
		private AudioSource tabChangeSource;

		[SerializeField]
		private ScreenSystem _screenSystem;

		private bool hasInitialized;

		private Tab lastTab;

		private Tween _recheckTween;

		private bool hasPaidOut;

		public Tab LastTab => default(Tab);

		public ScreenSystem ScreenSystem => null;

		public event Action<Tab, Tab> OnTabPressed
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

		protected void Start()
		{
		}

		private void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		protected override void OnOpen()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPayout_003Ed__21))]
		private IEnumerator DelayPayout()
		{
			return null;
		}

		private void PayoutEarnings()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayStart_003Ed__23))]
		private IEnumerator DelayStart()
		{
			return null;
		}

		private void GearCollected(ScriptableGear obj)
		{
		}

		private void ParseCurrencyEvents(string events)
		{
		}

		private void Recheck(double obj)
		{
		}

		public void OnTabClicked(int tab)
		{
		}

		public void CheckWarnings()
		{
		}

		public void OnTabClicked(Tab tab)
		{
		}

		public void TryAddTab(Tab thisTabType, PreGameTabController preGameTabController)
		{
		}

		public void TryRemoveTab(Tab thisTabType)
		{
		}
	}
}
