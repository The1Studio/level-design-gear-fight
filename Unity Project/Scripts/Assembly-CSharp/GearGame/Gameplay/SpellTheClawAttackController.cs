using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellTheClawAttackController : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] slashSystems;

		[SerializeField]
		private float delayBetweenAttacks;

		[SerializeField]
		private float delayDestroy;

		[SerializeField]
		private AudioSourceVariable attackSource;

		[SerializeField]
		private AudioSourceVariable critSource;

		private TroopController targetEnemy;

		private float slashDelay;

		private int slashesRemaining;

		private int slashOn;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void Slash()
		{
		}
	}
}
