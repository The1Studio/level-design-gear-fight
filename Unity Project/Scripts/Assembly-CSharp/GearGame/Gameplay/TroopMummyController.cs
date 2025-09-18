using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopMummyController : TroopController
	{
		[CompilerGenerated]
		private sealed class _003CDoUltimate_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopMummyController _003C_003E4__this;

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
			public _003CDoUltimate_003Ed__15(int _003C_003E1__state)
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

		private MummyData _data;

		[SerializeField]
		private TroopController characterController;

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private TroopMovementController movementController;

		[SerializeField]
		private TroopStateController stateController;

		[SerializeField]
		private ParticleSystem healSystem;

		private readonly int specialAttackHash;

		private float specialAttackCooldown;

		private float specialAttackCharge;

		private bool effectActive;

		public override TroopData Data => null;

		protected override void Update()
		{
		}

		public void OnEffectCompleted()
		{
		}

		public void OnEffectApex()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUltimate_003Ed__15))]
		private IEnumerator DoUltimate()
		{
			return null;
		}
	}
}
