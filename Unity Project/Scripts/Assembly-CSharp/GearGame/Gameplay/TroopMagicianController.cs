using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopMagicianController : TroopController
	{
		[CompilerGenerated]
		private sealed class _003CDoUltimate_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopMagicianController _003C_003E4__this;

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
			public _003CDoUltimate_003Ed__18(int _003C_003E1__state)
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

		private MagicianData _data;

		[SerializeField]
		private TroopController characterController;

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private TroopMovementController movementController;

		[SerializeField]
		private TroopStateController stateController;

		[SerializeField]
		private Transform laserSpawnTransform;

		[SerializeField]
		private GameObject laserPrefab;

		private readonly int specialAttackHash;

		private float specialAttackCooldown;

		private float specialAttackCharge;

		private GameObject laserObject;

		private bool isLaserAttacking;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		private void IncrementPower()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUltimate_003Ed__18))]
		private IEnumerator DoUltimate()
		{
			return null;
		}
	}
}
