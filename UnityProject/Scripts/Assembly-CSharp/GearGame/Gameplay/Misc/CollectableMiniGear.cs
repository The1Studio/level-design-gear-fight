using DG.Tweening;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using Items;
using UnityEngine;

namespace GearGame.Gameplay.Misc
{
	public class CollectableMiniGear : MiniGearDisplay
	{
		[SerializeField]
		private ShadowProjector shadowProjector;

		[SerializeField]
		private GameObject shineObject;

		[SerializeField]
		private Transform worldPositionForSpawningUIElements;

		[SerializeField]
		private float delayBeforeAutoCollect;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float jumpOffsetMin;

		[SerializeField]
		private float jumpOffsetMax;

		[SerializeField]
		private float jumpOffsetRandomMin;

		[SerializeField]
		private float jumpOffsetRandomMax;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private float tapRange;

		private Tween jump;

		private bool isCollected;

		private TransactionLocation location;

		public Transform WorldPositionForSpawningUIElements => null;

		public ScriptableGear Gear { get; private set; }

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		private void CollectThis()
		{
		}

		private void OnLanded()
		{
		}

		public void JumpTowardsCenter()
		{
		}

		public void JumpRandom()
		{
		}

		public override void InitializeGear(ScriptableGear gear, TransactionLocation location)
		{
		}
	}
}
