using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopMinotaurController : TroopController
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public TroopController targetEnemy;

			public Vector2 startingPosition;

			public Vector3 adder2;

			public Vector2 startingPositionForAdder;

			public TroopMinotaurController _003C_003E4__this;

			internal void _003CDoUltimate_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoUltimate_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopMinotaurController _003C_003E4__this;

			private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

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
			public _003CDoUltimate_003Ed__14(int _003C_003E1__state)
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

		private MinotaurData _data;

		[SerializeField]
		private TroopController characterController;

		[SerializeField]
		private TroopAnimationController animationController;

		[SerializeField]
		private TroopMovementController movementController;

		[SerializeField]
		private TroopStateController stateController;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private AudioSourceVariable hitSource;

		[SerializeField]
		private float motionTime;

		private readonly int specialAttackHash;

		private Vector3 lastPosition;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		private void LateUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUltimate_003Ed__14))]
		private IEnumerator DoUltimate()
		{
			return null;
		}
	}
}
