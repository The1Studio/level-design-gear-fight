using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Control;
using GearGame.Gameplay;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class SkipTicketTutorialController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayAttachToStore_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkipTicketTutorialController _003C_003E4__this;

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
			public _003CDelayAttachToStore_003Ed__7(int _003C_003E1__state)
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
		private ScriptableGear freeGear;

		[SerializeField]
		private GameObject handObject;

		private GearController[] gears;

		private void Start()
		{
		}

		private void GearChanged(GearController gear)
		{
		}

		private void MarkAsFinished()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayAttachToStore_003Ed__7))]
		private IEnumerator DelayAttachToStore()
		{
			return null;
		}
	}
}
