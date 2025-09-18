using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopAnimationController : MonoBehaviour
	{
		[SerializeField]
		private Animator animator;

		private readonly int hashHit;

		private void OnValidate()
		{
		}

		public void SetInteger(int hash, int value)
		{
		}

		public void SetBool(int hash, bool value)
		{
		}

		public void SetTrigger(int hash)
		{
		}

		public void Hit()
		{
		}

		public void SetSpeed(float speed)
		{
		}
	}
}
