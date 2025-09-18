using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class FirstTutorialController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FirstTutorialController _003C_003E4__this;

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
			public _003CStart_003Ed__7(int _003C_003E1__state)
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
		private Animator anim;

		[SerializeField]
		private GameObject rerollObject;

		[SerializeField]
		private GameObject fightObject;

		[SerializeField]
		private GearSellingController sellingController;

		[SerializeField]
		private Vector2Int targetPegIndex;

		private GearPeg targetPeg;

		private List<GearPeg> ignorePegs;

		[IteratorStateMachine(typeof(_003CStart_003Ed__7))]
		private IEnumerator Start()
		{
			return null;
		}

		private void Update()
		{
		}

		private void MarkAsFinished()
		{
		}

		private void IncrementTutorial(GearController _)
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}
	}
}
