using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellShootingTargeterController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private AudioSourceVariable shootSource;

		private float shootDelay;

		private TroopController targetEnemy;

		private float currentLerp;

		private bool hasShot;

		private bool isLocked;

		private readonly int lockedHash;

		private readonly int shootHash;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}
	}
}
