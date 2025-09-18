using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Canvas
{
	public class BackupAdsCanvas : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimate_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BackupAdsCanvas _003C_003E4__this;

			public Vector2 sourcePosition;

			public float duration;

			public Vector2 targetPosition;

			private float _003Ctime_003E5__2;

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
			public _003CAnimate_003Ed__32(int _003C_003E1__state)
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
		private sealed class _003CAnimateHide_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BackupAdsCanvas _003C_003E4__this;

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
			public _003CAnimateHide_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CAnimateShow_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BackupAdsCanvas _003C_003E4__this;

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
			public _003CAnimateShow_003Ed__30(int _003C_003E1__state)
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

		private const string TAG = "BackupAdsCanvas";

		private const float BACK_FROM_UNFOCUS_MAX_DELTA_TIME = 0.33333f;

		public SimpleVideoPlayer videoPlayer;

		public Button closeButton;

		public TextMeshProUGUI timerText;

		public GameObject endScreen;

		public RectTransform interstitialParent;

		public TextMeshProUGUI downloadText;

		[Header("Sound")]
		public Button muteButton;

		public Image muteImage;

		public Sprite soundOnIcon;

		public Sprite soundOffIcon;

		private Action _closeCallback;

		private float _delayBeforeShowingCloseButton;

		private float _elapsedTime;

		private bool _delayElapsed;

		private bool _isPaused;

		private Action<bool> _completeCallback;

		private UnityEngine.Canvas _canvas;

		private BackupAdsInfo _info;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public void PlayAd(BackupAdsInfo info, float duration, Action<bool> onComplete, Action onClose, Action onClicked)
		{
		}

		private void AdjustDuration(VideoPlayer player)
		{
		}

		private void ShowCanvas()
		{
		}

		private void HideCanvas()
		{
		}

		[IteratorStateMachine(typeof(_003CAnimateShow_003Ed__30))]
		private IEnumerator AnimateShow()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAnimateHide_003Ed__31))]
		private IEnumerator AnimateHide()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAnimate_003Ed__32))]
		private IEnumerator Animate(Vector2 sourcePosition, Vector2 targetPosition, float duration)
		{
			return null;
		}

		private void StartVideo()
		{
		}

		private void OnVideoCompleted()
		{
		}

		private void ActivateCloseButtonDelay()
		{
		}

		private void DeactivateCloseButtonDelay()
		{
		}

		private void OnCloseButtonClicked()
		{
		}

		private void OnMuteButtonClicked()
		{
		}

		private void ToggleSound()
		{
		}

		private void MakeSureAllCanvasAreBelowThisOne()
		{
		}
	}
}
