using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellBeeHiveController : MonoBehaviour
	{
		[SerializeField]
		private BeeSwarmController beeAttackPrefab;

		[SerializeField]
		private GameObject deathObject;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private float timeBetweenTicks;

		[SerializeField]
		private float halfWidth;

		[SerializeField]
		private float aliveTimer;

		private float tickTimer;

		private void Update()
		{
		}

		private void TryAddBeesToEnemy(TroopController character)
		{
		}
	}
}
