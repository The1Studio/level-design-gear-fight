using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopNinjaController : TroopController
	{
		[CompilerGenerated]
		private sealed class _003CDoUltimate_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopNinjaController _003C_003E4__this;

			private float _003ClastCritChance_003E5__2;

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
			public _003CDoUltimate_003Ed__11(int _003C_003E1__state)
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

		private NinjaData _data;

		[SerializeField]
		private TroopController characterController;

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private TroopMovementController movementController;

		[SerializeField]
		private TroopStateController stateController;

		[SerializeField]
		private SpriteRenderer displaySprite;

		private readonly int specialAttackHash;

		private float sneakAttackCooldown;

		public override TroopData Data => null;

		protected override void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUltimate_003Ed__11))]
		private IEnumerator DoUltimate()
		{
			return null;
		}
	}
}
