using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class UnityMainThreadDispatcher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActionWrapper_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action a;

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
		public _003CActionWrapper_003Ed__5(int _003C_003E1__state)
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

	private static readonly Queue<Action> _executionQueue;

	private static UnityMainThreadDispatcher _instance;

	public void Update()
	{
	}

	public void Enqueue(IEnumerator action)
	{
	}

	public void Enqueue(Action action)
	{
	}

	public Task EnqueueAsync(Action action)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CActionWrapper_003Ed__5))]
	private IEnumerator ActionWrapper(Action a)
	{
		return null;
	}

	public static bool Exists()
	{
		return false;
	}

	public static UnityMainThreadDispatcher Instance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
