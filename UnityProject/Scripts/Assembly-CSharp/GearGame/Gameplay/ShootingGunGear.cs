using Gameplay._Data;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class ShootingGunGear : GearSpawnerController
	{
		[SerializeField]
		private Transform bulletSpawnTransform;

		[SerializeField]
		private Transform gunTransform;

		[SerializeField]
		private ParticleSystem shootingMuzzleSystem;

		[SerializeField]
		private Animator shootingAnimator;

		[SerializeField]
		private AudioSource shootSource;

		private TroopController targetEnemy;

		private Vector3 defaultLookDirection;

		private float currentDelay;

		private int currentAmmo;

		private float bulletSpeed;

		private readonly int shootingHash;

		public abstract GunData GunData { get; }

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override GearSpawnerData SpawnerData => null;

		protected override float MaxProduction => 0f;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		private void GunStateChanged(GameStateManager.GameState state)
		{
		}

		protected override void ObjectSpawned(GameObject go)
		{
		}

		protected override GameObject SpawnObject(bool _)
		{
			return null;
		}

		private void ReturnToDefault()
		{
		}

		protected override string GetProductionDisplayText(float output)
		{
			return null;
		}

		private void ShootBullet()
		{
		}

		private void ShootGun()
		{
		}
	}
}
