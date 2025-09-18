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
	[RequireComponent(typeof(GearSpawnerReferenceContainer))]
	public abstract class GearSpawnerController : GearController, IGearProductionUpdater
	{
		[CompilerGenerated]
		private sealed class _003CDelaySpin_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearSpawnerController _003C_003E4__this;

			public float number;

			public float delay;

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
			public _003CDelaySpin_003Ed__65(int _003C_003E1__state)
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

		protected float requiredNumber;

		protected float cooldown;

		private List<Tuple<object, float>> allExternalProductionMultipliers;

		protected MaterialPropertyBlock fillBlock;

		protected GearSpawnerReferenceContainer gearSpawnerReferenceContainer;

		private float lastDisplayValue;

		private float targetFillValue;

		private float currentFillValue;

		protected float currentCooldown;

		protected float currentNumber;

		private bool pendingValueUpdate;

		protected bool pendingLaunch;

		protected bool isLocked;

		protected int lockNum;

		protected float productionMultiplier;

		protected float externalProductionMultiplier;

		private bool hasInitializedDisplayValue;

		public float LastDisplayValue => 0f;

		public float RequiredNumber => 0f;

		public float Cooldown => 0f;

		public override bool CanBeFrozen => false;

		public GearSpawnerReferenceContainer GearSpawnerReferenceContainer => null;

		public SpriteRenderer FillSprite => null;

		public Transform SpawnTransform => null;

		public float ActualProductionOutput { get; protected set; }

		public bool ProductionLocked { get; protected set; }

		public bool ResetProgressBetweenFights { get; protected set; }

		public abstract GearSpawnerData SpawnerData { get; }

		public override GearData GearData => null;

		protected abstract float MaxProduction { get; }

		public event Action<GearSpawnerController, GameObject> OnObjectSpawned
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

		protected abstract void ObjectSpawned(GameObject go);

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected virtual string GetProductionDisplayText(float output)
		{
			return null;
		}

		private void SetFillValue01(float value01)
		{
		}

		protected new virtual void StateChanged(GameStateManager.GameState state)
		{
		}

		public void TriggerPendingValueUpdate()
		{
		}

		public override void Rotate(float rotation, GearPeg startingPeg, GearPeg previousPeg)
		{
		}

		public void AddExternalProductionModifier(object o, float additionalMultiplier)
		{
		}

		public void RemoveExternalProductionMultiplier(object o)
		{
		}

		private void RecalculateExternalProductionMultiplier()
		{
		}

		[IteratorStateMachine(typeof(_003CDelaySpin_003Ed__65))]
		private IEnumerator DelaySpin(float number, float delay)
		{
			return null;
		}

		protected virtual void DoSpawn(int spawnNumber)
		{
		}

		protected virtual void DoSpawnAction()
		{
		}

		protected virtual GameObject InstantiateSpawnObject()
		{
			return null;
		}

		protected virtual GameObject SpawnObject(bool setPosition)
		{
			return null;
		}

		private void NotifySpawning()
		{
		}
	}
}
