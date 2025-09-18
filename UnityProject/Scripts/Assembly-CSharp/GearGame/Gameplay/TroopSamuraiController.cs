using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopSamuraiController : TroopController
	{
		[CompilerGenerated]
		private sealed class _003CDoUltimate_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopSamuraiController _003C_003E4__this;

			private EnemyManager _003Cmanager_003E5__2;

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

		private SamuraiData _data;

		[SerializeField]
		private TroopController characterController;

		[SerializeField]
		private TroopMovementController movementController;

		[SerializeField]
		private TroopStateController stateController;

		[SerializeField]
		private ParticleSystem dashSystem;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private AudioSource slashAttackSource;

		[SerializeField]
		private AudioSourceVariable impactSource;

		private float lastCheckTimeForActive;

		private Vector2 lastPosition;

		private float slashAttackCooldown;

		private List<TroopController> healthControllers;

		public override TroopData Data => null;

		protected override void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUltimate_003Ed__15))]
		private IEnumerator DoUltimate()
		{
			return null;
		}

		private void UpdateAttack()
		{
		}

		private void DoDamage(TroopController controller)
		{
		}
	}
}
