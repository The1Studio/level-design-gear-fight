using System.Collections.Generic;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellZombieArmAttackController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private float halfWidth;

		[SerializeField]
		private float timeBetweenTicks;

		[SerializeField]
		private AudioSourceVariable hitSound;

		[SerializeField]
		private bool hitEnemies;

		private bool isLeaving;

		private float aliveTimer;

		private float tickTimer;

		private readonly List<TroopController> enemyControllers;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void ApplyBaseDamage()
		{
		}

		public void OnAnimationCompleted()
		{
		}

		private void CheckEnemies()
		{
		}

		public void ApplyDamage(double amount)
		{
		}
	}
}
