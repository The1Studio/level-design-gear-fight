using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace GearGame.Gameplay
{
	public abstract class TroopController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDeactivateBeastMode_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TroopController _003C_003E4__this;

			public float addedKnockback;

			public double addedDamage;

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
			public _003CDeactivateBeastMode_003Ed__82(int _003C_003E1__state)
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

		public UnityEvent OnThisKilled;

		[FormerlySerializedAs("distanceOffset")]
		[SerializeField]
		private float troopWidth;

		private TroopReferenceContainer troopReferenceContainer;

		private TroopCombatController combatController;

		private TroopHealthController healthController;

		private TroopController targetEnemy;

		protected int currentEvolution;

		private float killPositionX;

		private float frozenTimer;

		private float lastPositionX;

		private float lastCheckTime;

		private float spawnTime;

		public bool IsAlly { get; private set; }

		public bool IsTargetable { get; set; }

		public bool HasMeat { get; private set; }

		public bool HasPepper { get; set; }

		public bool IncomingPepper { get; set; }

		public bool HasStar { get; private set; }

		public bool CanPushMovementControllers { get; set; }

		public int KillValue { get; set; }

		public bool IsBeast { get; private set; }

		public int Level { get; private set; }

		public ScriptableTroop Troop { get; private set; }

		public abstract TroopData Data { get; }

		public TroopReferenceContainer TroopReferenceContainer => null;

		[field: SerializeField]
		public int Priority { get; private set; }

		public TroopHealthController HealthController => null;

		public TroopCombatController CombatController => null;

		public TroopController TargetEnemy => null;

		public float TroopWidth => 0f;

		public event Action<TroopController> OnCharacterKilled
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetStartTimer(float timer)
		{
		}

		public void Initialize(bool isAlly, ScriptableTroop troop, int level, float healthMultiplier = 1f, float damageMultiplier = 1f)
		{
		}

		public void ActivateBeastMode()
		{
		}

		[IteratorStateMachine(typeof(_003CDeactivateBeastMode_003Ed__82))]
		public IEnumerator DeactivateBeastMode(double addedDamage, float addedKnockback)
		{
			return null;
		}

		private void CharacterAttacked(TroopController obj)
		{
		}

		public float GetKillPositionX()
		{
			return 0f;
		}

		protected bool IsPastKillPosition(float x)
		{
			return false;
		}

		protected void OnReachedEnemyKillSide()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void FreezeThis(float duration)
		{
		}

		private void SetFrozenStatus(bool status)
		{
		}

		public void EatPepper()
		{
		}

		public void EatMeat(float healthMultiplier, float additionalKnockback)
		{
		}

		public void EatStar(float duration, float damageMultiplier, float healthMultiplier, float speedMultiplier)
		{
		}

		public void SetTarget(TroopController character)
		{
		}

		private void TryFindTarget()
		{
		}

		protected virtual void OnKilled(TroopHealthController characterKilled)
		{
		}

		protected void DoKill()
		{
		}
	}
}
