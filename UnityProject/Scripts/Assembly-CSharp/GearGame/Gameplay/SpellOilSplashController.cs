using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellOilSplashController : SpellLaunchedBomb
	{
		[SerializeField]
		private float delayActivate;

		[SerializeField]
		private float areaOfEffect;

		[SerializeField]
		private GameObject explosionObject;

		[Tooltip("This game object will be deactivated when this projectile explodes. It SHOULD NOT have any logic on it!")]
		[SerializeField]
		private GameObject launchedProjectileGFXRoot;

		private GroundAOEEffect fireObject;

		private bool hasExploded;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void OnCompleted()
		{
		}

		protected override void Explode()
		{
		}
	}
}
