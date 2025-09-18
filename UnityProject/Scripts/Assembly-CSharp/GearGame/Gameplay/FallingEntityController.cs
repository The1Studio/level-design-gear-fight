using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class FallingEntityController : MonoBehaviour
	{
		[Serializable]
		public struct FallAngleChance
		{
			[field: SerializeField]
			public float RotationValue { get; private set; }

			[field: SerializeField]
			public bool DoRoll { get; private set; }

			[field: SerializeField]
			public float Probability { get; private set; }

			public static implicit operator Tuple<float, FallAngleChance>(FallAngleChance fallAngleChance)
			{
				return null;
			}
		}

		[Serializable]
		public class VelocityProfile
		{
			[SerializeField]
			private InitialVelocityMode velocityMode;

			[SerializeField]
			private Vector2 forceRange;

			[SerializeField]
			private Vector2 centerOffsetRange;

			[SerializeField]
			private Vector2 yPowerRange;

			[SerializeField]
			private float delayTimer;

			[SerializeField]
			private bool useCollider;

			public InitialVelocityMode VelocityMode => default(InitialVelocityMode);

			public Vector2 ForceRange => default(Vector2);

			public Vector2 CenterOffsetRange => default(Vector2);

			public Vector2 YPowerRange => default(Vector2);

			public bool UseCollider => false;

			public float DelayTimer
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}
		}

		public enum InitialVelocityMode
		{
			None = 0,
			Random = 1,
			RandomUp = 2,
			TowardsCenter = 3,
			CenterOffset = 4
		}

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FallingEntityController _003C_003E4__this;

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
			public _003CStart_003Ed__17(int _003C_003E1__state)
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
		private Rigidbody2D rb;

		[SerializeField]
		private TroopSortingController sortingController;

		[SerializeField]
		private FallAngleChance[] allFallAngleChances;

		[SerializeField]
		protected VelocityProfile velocityProfile;

		[SerializeField]
		private GameObject _deathVFX;

		private bool overrideY;

		protected float finalYPosition;

		protected float spawnTimer;

		private float rotationAngleOnTreadmill;

		private bool doRoll;

		private bool isColliding;

		private float rollAdder;

		private const float launchVelocityForceDivisionValue = 5f;

		private GameObject itemSpawn;

		[IteratorStateMachine(typeof(_003CStart_003Ed__17))]
		private IEnumerator Start()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionStay2D(Collision2D collision)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void SetSpawnObject(GameObject spawnObject)
		{
		}

		protected virtual void Launch()
		{
		}

		public void OverrideYPosition(float pos)
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		protected virtual void Convert()
		{
		}
	}
}
