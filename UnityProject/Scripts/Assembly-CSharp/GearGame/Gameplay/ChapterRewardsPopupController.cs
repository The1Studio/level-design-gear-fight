using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.UI;
using GearGame.Control;
using GearGame.Managers.SingleLoad;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay
{
	public class ChapterRewardsPopupController : Popup
	{
		[CompilerGenerated]
		private sealed class _003CDelayRebuild_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChapterRewardsPopupController _003C_003E4__this;

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
			public _003CDelayRebuild_003Ed__10(int _003C_003E1__state)
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
		private HorizontalLayoutGroup layoutGroup;

		[SerializeField]
		private TextMeshProUGUI gemsPayoutText;

		[SerializeField]
		private TextMeshProUGUI chestPayoutText;

		[SerializeField]
		private TextMeshProUGUI xpPayoutText;

		[SerializeField]
		private CurrencySO gemCurrency;

		[SerializeField]
		private CurrencySO chestCurrency;

		[SerializeField]
		private GameObject chestRoot;

		[SerializeField]
		private GameObject xpRoot;

		private ChapterRewardsManager.ChapterReward reward;

		public void Initialize(ChapterRewardsManager.ChapterReward reward)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayRebuild_003Ed__10))]
		private IEnumerator DelayRebuild()
		{
			return null;
		}

		public void OnCollectPressed()
		{
		}
	}
}
