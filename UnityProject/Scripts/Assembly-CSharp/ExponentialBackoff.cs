using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExponentialBackoff : MonoBehaviour
{
	public class ExpBackoff
	{
		public float[] Delays;

		public Action Callback;

		public string Name;

		private Coroutine _coroutine;

		private int _currentDelayIndex;

		public void Start()
		{
		}

		public void Reset()
		{
		}

		public void Restart()
		{
		}

		private void Stop()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CBackoffCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string name;

		public float delay;

		public Action callback;

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
		public _003CBackoffCoroutine_003Ed__5(int _003C_003E1__state)
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

	private const string TAG = "ExponentialBackoff";

	private static ExponentialBackoff _instance;

	private void Awake()
	{
	}

	public static ExpBackoff CreateExpBackoff(Action callback, string name, float[] delays = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBackoffCoroutine_003Ed__5))]
	private static IEnumerator BackoffCoroutine(float delay, Action callback, string name)
	{
		return null;
	}
}
