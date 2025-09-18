using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellCornController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private ParticleSystem system;

		[SerializeField]
		private float halfWidthForActivation;

		[SerializeField]
		private float halfWidthForDamage;

		private float lastCheck;

		private bool hasTriggered;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		private void CheckTargets()
		{
		}

		private void Trigger()
		{
		}

		public void ActivationCallback()
		{
		}
	}
}
