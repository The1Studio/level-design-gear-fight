using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellSunflowerSeedController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpellSunflowerSeedController _003C_003E4__this;

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
			public _003CStart_003Ed__14(int _003C_003E1__state)
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
		private float offsetRadius;

		[SerializeField]
		private float radianAdditionPerSeed;

		[SerializeField]
		private Vector2 delayRandomRange;

		[SerializeField]
		private Vector2 delayRandomRangeStart;

		[SerializeField]
		private AnimationCurve startingMotionCurve;

		[SerializeField]
		private float motionTime;

		[SerializeField]
		private AudioSourceVariable startMotionSource;

		[SerializeField]
		protected ProjectileController associatedProjectile;

		[SerializeField]
		protected float delay;

		private static float radianCurrent;

		private TroopController targetEnemy;

		private bool hasShot;

		private float delayDestroy;

		private float delayRecheck;

		[IteratorStateMachine(typeof(_003CStart_003Ed__14))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		protected void TryDoAttack(TroopController targetEnemy, double damageValue, float critMultiplier)
		{
		}

		protected TroopController TryGetCharacter()
		{
			return null;
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}
	}
}
