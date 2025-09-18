using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class SpellLaunchedBomb : MonoBehaviour
	{
		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float jumpTimer;

		private Vector2 lastPosition;

		protected abstract void Explode();

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
