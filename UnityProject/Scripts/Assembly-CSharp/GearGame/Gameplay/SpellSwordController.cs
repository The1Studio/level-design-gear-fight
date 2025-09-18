using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellSwordController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		protected TroopController targetEnemy;

		private float currentLerp01;

		private bool isSlicing;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}

		public virtual void OnSlice()
		{
		}

		public void AnimationCompleted()
		{
		}
	}
}
