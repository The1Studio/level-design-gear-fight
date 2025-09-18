using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellWateringCanController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayEnd_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpellWateringCanController _003C_003E4__this;

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
			public _003CDelayEnd_003Ed__8(int _003C_003E1__state)
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
		private Vector3 offset;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private AnimationCurve curve;

		[SerializeField]
		private float motionTime;

		private bool isWatering;

		private GearSpawnerController targetController;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayEnd_003Ed__8))]
		private IEnumerator DelayEnd()
		{
			return null;
		}

		public void OnExitAnimationCompleted()
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}
	}
}
