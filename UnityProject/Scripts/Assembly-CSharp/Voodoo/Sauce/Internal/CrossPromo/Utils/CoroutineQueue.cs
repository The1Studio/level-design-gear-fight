using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voodoo.Sauce.Internal.CrossPromo.Utils
{
	public class CoroutineQueue
	{
		[CompilerGenerated]
		private sealed class _003CProcess_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoroutineQueue _003C_003E4__this;

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
			public _003CProcess_003Ed__7(int _003C_003E1__state)
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

		private readonly MonoBehaviour _owner;

		private Coroutine _internalCoroutine;

		private readonly Queue<IEnumerator> _actions;

		public CoroutineQueue(MonoBehaviour owner)
		{
		}

		private void StartLoop()
		{
		}

		private void StopLoop()
		{
		}

		public void EnqueueAction(IEnumerator action)
		{
		}

		[IteratorStateMachine(typeof(_003CProcess_003Ed__7))]
		private IEnumerator Process()
		{
			return null;
		}
	}
}
