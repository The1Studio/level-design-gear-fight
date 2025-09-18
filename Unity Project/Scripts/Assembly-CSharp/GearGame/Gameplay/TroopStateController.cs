using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopStateController : MonoBehaviour
	{
		public enum State
		{
			Idle = 0,
			Running = 1,
			Attacking = 2
		}

		[SerializeField]
		private TroopAnimationController characterAnimationController;

		private readonly int hashState;

		private readonly int hopHash;

		private State currentState;

		private bool canWalk;

		public State CurrentState => default(State);

		private void OnValidate()
		{
		}

		public void SetState(State state)
		{
		}

		public void DeactivateWalking()
		{
		}

		public void TriggerHop()
		{
		}
	}
}
