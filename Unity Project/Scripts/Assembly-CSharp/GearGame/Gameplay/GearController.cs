using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gameplay._Data;
using GearGame.Advertising;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	[RequireComponent(typeof(GearAudioReferenceContainer), typeof(GearBaseReferenceContainer))]
	public abstract class GearController : MonoBehaviour
	{
		public enum PlacementResult
		{
			Error = 0,
			Place = 1,
			Swap = 2,
			Merge = 3,
			Sell = 4
		}

		public enum LockType
		{
			NotLocked = 0,
			TempLocked = 1,
			PermanentLocked = 99,
			CompleteFreeze = 100
		}

		[Flags]
		public enum MotionBlockDirection
		{
			None = 0,
			Left = 1,
			Right = 4,
			Up = 2,
			Down = 8,
			All = 0xF
		}

		public const float DisplayMultiplier = 4f;

		protected readonly List<Type> activeBuffs;

		protected float scoreValue;

		protected float scoreValueBase;

		protected bool wiggleOnFailedRotation;

		protected GearAudioReferenceContainer audioContainer;

		protected GearBaseReferenceContainer baseReferenceContainer;

		private GearStoreSlot preADGearHolder;

		protected MaterialPropertyBlock gearBlock;

		private float targetScale;

		private Vector3 lastCheckedPosition;

		protected bool selected;

		protected bool pendingVariableStateCheck;

		protected float rotationValue;

		private IGearHolder currentGearHolder;

		private PlacementResult lastResult;

		private GearController lastDisplay;

		private float targetRotation;

		private int currentCost;

		protected float targetGrayscale;

		private float currentGrayscale;

		private float timeOfHoldStart;

		private Tween rotationPunch;

		private bool canAcceptTempLocks;

		protected readonly List<object> allRotationBlockers;

		protected readonly List<object> allFreezeEnforcers;

		protected readonly List<object> allMergeBlockers;

		protected readonly List<Tuple<object, LockType>> allLocks;

		public float TargetRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurrentRotation => 0f;

		public int SellValue => 0;

		public int CurrentCost => 0;

		public float ScoreValue => 0f;

		public IList<Type> ActiveBuffs => null;

		public SpriteRenderer GearSpriteRenderer => null;

		public virtual int CalculationPrioirtyHigherFirst => 0;

		public bool IsFrozen => false;

		public bool CanRotate => false;

		public bool Mergeable => false;

		public bool Moveable => false;

		public abstract ScriptableGear.GearType GearType { get; }

		public abstract bool CanBeFrozen { get; }

		public int GemCost { get; set; }

		public float TargetScale => 0f;

		public ScriptableGear ScriptableGear { get; set; }

		public bool Static { get; private set; }

		public bool Destroyed { get; private set; }

		public virtual bool RotateWithNeighbors => false;

		public Vector2 RestingPosition { get; set; }

		public Vector2 TargetSize { get; set; }

		public Transform TrackingTransform { get; private set; }

		public Vector2 TargetPosition { get; private set; }

		public RewardedADButtonController RewardedADButtonForPurchase { get; set; }

		public float DelayMotion { get; set; }

		public abstract GearData GearData { get; }

		public virtual IGearHolder CurrentGearHolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual bool JumpToTargetRotationOnPlacement => false;

		protected virtual bool GrayIfNotInChain => false;

		public event Action<GearController> OnPurchased
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

		public event Action<GearController> OnFailedPurchased
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

		public event Action<GearController, bool> OnSelectionStatusChanged
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

		public event Action<GearController> OnGearRotated
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

		public event Action<GearController> OnTempLocksCleared
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

		public event Action<bool> OnFrozenStatusChanged
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

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void DoScale()
		{
		}

		private void GearPurchased(GearController _)
		{
		}

		private List<GearPeg> GetLockPegs()
		{
			return null;
		}

		public void RemoveMovementBlocker(MotionBlockDirection direction)
		{
		}

		public void AddMovementBlocker(MotionBlockDirection direction)
		{
		}

		public void AddFreezeEnforcer(object o)
		{
		}

		public void RemoveFreezeEnforcer(object o)
		{
		}

		private void ClearPegLocks()
		{
		}

		private void SetPegLocks()
		{
		}

		public virtual string GetProductionDisplayString()
		{
			return null;
		}

		public void OnGearChanged()
		{
		}

		public bool IsAttachedToSpinner()
		{
			return false;
		}

		public virtual void CheckVariableStates()
		{
		}

		private static MotionBlockDirection GetMotionDirection(GearPeg root, GearPeg target)
		{
			return default(MotionBlockDirection);
		}

		public virtual float GetScoreValue(float currentScoreValue)
		{
			return 0f;
		}

		public void SetCost(int cost)
		{
		}

		protected virtual void StateChanged(GameStateManager.GameState state)
		{
		}

		public void SetTrackingTransform(Transform transform)
		{
		}

		protected virtual void UpdateRotation()
		{
		}

		public void PunchRotation(Vector3 punch, float duration)
		{
		}

		protected void AddRotationBlocker(object o)
		{
		}

		protected void RemoveRotationBlocker(object o)
		{
		}

		public bool ValidateRotation(GearPeg previousPeg)
		{
			return false;
		}

		public void TryWiggle(float rotation)
		{
		}

		public virtual void Rotate(float rotation, GearPeg startingPeg, GearPeg previousPeg)
		{
		}

		public void AddLock(object o, LockType lockType, bool allowGearBlockGFX = true)
		{
		}

		public void RemoveLock(object o)
		{
		}

		private void RemoveTempLocks()
		{
		}

		public void AddMergeBlocker(object o)
		{
		}

		public void RemoveMergeBlocker(object o)
		{
		}

		public void SetStaticStatus(bool staticStatus)
		{
		}

		public void Shake()
		{
		}

		public virtual void BreakThis()
		{
		}

		public void SellThis()
		{
		}

		private void SetMergeHighlight(bool status)
		{
		}

		private void ResetLastDisplayHighlight()
		{
		}

		private void RewardedADCompleted(bool status)
		{
		}

		private PlacementResult GetPlacementResult(Vector3 worldPosition, out GearController gear, out GearPeg peg, out GearDeadzone deadzone, out GearSellingController sellingController)
		{
			gear = null;
			peg = null;
			deadzone = null;
			sellingController = null;
			return default(PlacementResult);
		}

		public void OnBeginDrag()
		{
		}

		public void OnDrag()
		{
		}

		public void OnEndDrag()
		{
		}

		private GearController Evolve()
		{
			return null;
		}

		protected virtual void OnMerge(GearController newGear, GearController gear1, GearController gear2)
		{
		}

		public void JumpToPosition()
		{
		}

		public void SetTargetPositionToResting()
		{
		}

		public void TriggerBoop(float delay)
		{
		}

		public bool TryAddBuff(BoostController buffController)
		{
			return false;
		}

		public void RemoveBuff(BoostController buffController)
		{
		}
	}
}
