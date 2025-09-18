using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core.UI;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Refactor.Popups
{
	public class FeatureUnlockedPopup : Popup
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CActivate_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FeatureUnlockedPopup _003C_003E4__this;

			public List<UnityEvent> unityEvents;

			public string text;

			public Sprite sprite;

			public Image endTargetImage;

			private TaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDelayEnable_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FeatureUnlockedPopup _003C_003E4__this;

			public int delay;

			private TaskAwaiter _003C_003Eu__1;

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
		private TextMeshProUGUI _text;

		[SerializeField]
		private Image _image;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private SimpleAnimationCallbackHandler _animationHandler;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private AnimationCurve _jumpCurve;

		[SerializeField]
		private AnimationCurve _scaleCurve;

		[SerializeField]
		private float _jumpHeight;

		[SerializeField]
		private float _jumpDuration;

		[SerializeField]
		private float _jumpDelayBase;

		private List<Tween> allTweens;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CActivate_003Ed__13))]
		public Task Activate(string text, Sprite sprite, Image endTargetImage, List<UnityEvent> unityEvents)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDelayEnable_003Ed__14))]
		private void DelayEnable(int delay)
		{
		}
	}
}
