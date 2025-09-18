using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.UI;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using GearGame.SingleLoad;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class PreGameRootCanvasController : Core.UI.Screen
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PreGameRootCanvasController _003C_003E4__this;

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
			public _003CStart_003Ed__12(int _003C_003E1__state)
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
		private TextMeshProUGUI chapterNameText;

		[SerializeField]
		private TextMeshProUGUI progressNameText;

		[SerializeField]
		private TextMeshProUGUI levelDifficultyText;

		[SerializeField]
		private TextMeshProUGUI blueCoinsRewardText;

		[SerializeField]
		private TextMeshProUGUI greenCoinsRewardText;

		[SerializeField]
		private CurrencySO blueCoinsCurrency;

		[SerializeField]
		private CurrencySO greenCoinsCurrency;

		[SerializeField]
		private GameObject chestRewardDisplay;

		[SerializeField]
		private GameObject gearLoaoutDisplay;

		public event Action OnPlayButtonPressed
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

		[IteratorStateMachine(typeof(_003CStart_003Ed__12))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void ItemUnlocked(WorldMetaLockManager.UnlockDetail detail)
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void OnStartPressed()
		{
		}

		public void OnBlessingsButtonClicked()
		{
		}

		public void OnSettingsButtonClicked()
		{
		}
	}
}
