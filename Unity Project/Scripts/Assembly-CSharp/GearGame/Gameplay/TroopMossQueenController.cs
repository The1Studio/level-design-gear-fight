using Gameplay._Data;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopMossQueenController : TroopController
	{
		private MossQueenData _data;

		[SerializeField]
		private ScriptableTroop[] enemies;

		[SerializeField]
		private TroopHealthController characterHealthController;

		[SerializeField]
		private GameObject inactiveRoot;

		[SerializeField]
		private GameObject activeRoot;

		[SerializeField]
		private ParticleSystem groundBurst;

		[SerializeField]
		private TroopMovementController characterMovementController;

		private bool isActive;

		private double startingHealth;

		private float specialAttackCooldown;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		private void StateChanged(GameStateManager.GameState gameState)
		{
		}

		private void HealthChanged(TroopHealthController arg1, double health)
		{
		}

		private void WakeUp()
		{
		}

		private void Spawn(ScriptableTroop character)
		{
		}
	}
}
