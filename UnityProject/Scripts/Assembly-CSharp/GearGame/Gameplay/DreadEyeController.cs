using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class DreadEyeController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoUltimate_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DreadEyeController _003C_003E4__this;

			private float _003CdurationBetween_003E5__2;

			private int _003CremainingShots_003E5__3;

			private CharacterManager _003CtargetManager_003E5__4;

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

		[SerializeField]
		private TroopController characterController;

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private TroopCombatController combatController;

		[SerializeField]
		private TroopMovementController movementController;

		[SerializeField]
		private TroopStateController stateController;

		[SerializeField]
		private Transform projectileSpawnTransform;

		[SerializeField]
		private GameObject shootingProjectile;

		[SerializeField]
		private AudioSourceVariable shootingSource;

		[SerializeField]
		private float attackCooldown;

		[SerializeField]
		private float attackDuration;

		[SerializeField]
		private int numberProjectiles;

		private readonly int specialAttackHash;

		private float specialAttackCooldown;

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUltimate_003Ed__15))]
		private IEnumerator DoUltimate()
		{
			return null;
		}
	}
}
