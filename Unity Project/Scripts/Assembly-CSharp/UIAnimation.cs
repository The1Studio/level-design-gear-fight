using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class UIAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public AnimatedProperties anim;

		public Tween tween;

		public AnimationType type;

		public UIAnimation _003C_003E4__this;

		internal void _003CIAnimate_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CIAnimate_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimation _003C_003E4__this;

		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		private int _003Ccounter_003E5__2;

		private List<AnimatedProperties>.Enumerator _003C_003E7__wrap2;

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
		public _003CIAnimate_003Ed__15(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("VERSION: 1.1.2")]
	[Space]
	public bool PlayOnEnable;

	public float StartDelay;

	public float CurrentDelay;

	public int LoopCount;

	public bool IgnoreTimeScale;

	public List<AnimatedProperties> Animations;

	public AnimatedProperties[] TestAnimations;

	public AnimatedProperties TestAnimation;

	private RectTransform rect;

	public UnityEvent OnStart;

	public UnityEvent OnComplete;

	[Space]
	[Header("DEBUG")]
	public List<AnimationType> animTypes;

	private List<Tween> _tweens;

	private bool _isDisabling;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CIAnimate_003Ed__15))]
	public IEnumerator IAnimate()
	{
		return null;
	}

	public void InitStates(AnimatedProperties anim)
	{
	}

	public Tween CreateTween(AnimatedProperties anim)
	{
		return null;
	}

	public void TriggerAnimation()
	{
	}

	private void OnDisable()
	{
	}

	public void ForceDisable()
	{
	}

	public void AddNewAnimation()
	{
	}

	public void RemoveAnimation(int i)
	{
	}

	public void MoveUp(int i)
	{
	}

	public void MoveDown(int i)
	{
	}
}
