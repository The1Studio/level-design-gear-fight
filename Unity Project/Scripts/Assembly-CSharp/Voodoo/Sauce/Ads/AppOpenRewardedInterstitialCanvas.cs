using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Ads
{
	public class AppOpenRewardedInterstitialCanvas : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountdownCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AppOpenRewardedInterstitialCanvas _003C_003E4__this;

			public float waitDuration;

			public Action onCountdownElapsed;

			private float _003Ctime_003E5__2;

			private float _003Cprogress_003E5__3;

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
			public _003CCountdownCoroutine_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CEndCardCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AppOpenRewardedInterstitialCanvas _003C_003E4__this;

			public Action onComplete;

			public float waitDuration;

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
			public _003CEndCardCoroutine_003Ed__12(int _003C_003E1__state)
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
		private GameObject progressBarParent;

		[SerializeField]
		private Image progressBar;

		[SerializeField]
		private TMP_Text rewardText;

		private string _defaultRewardText;

		public bool IsShowing { get; private set; }

		private void Awake()
		{
		}

		public void Show(float waitDuration, Action onCountdownElapsed)
		{
		}

		public void ShowEndCard(float waitDuration, Action onComplete)
		{
		}

		public void SetReward(int reward)
		{
		}

		[IteratorStateMachine(typeof(_003CEndCardCoroutine_003Ed__12))]
		private IEnumerator EndCardCoroutine(float waitDuration, Action onComplete)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCountdownCoroutine_003Ed__13))]
		private IEnumerator CountdownCoroutine(float waitDuration, Action onCountdownElapsed)
		{
			return null;
		}

		public void Hide()
		{
		}
	}
}
