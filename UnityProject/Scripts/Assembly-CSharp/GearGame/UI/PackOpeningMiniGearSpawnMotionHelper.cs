using UnityEngine;

namespace GearGame.UI
{
	public class PackOpeningMiniGearSpawnMotionHelper : MonoBehaviour
	{
		[SerializeField]
		private Vector2 dampeningRange;

		[SerializeField]
		private Vector2 accelerationMultiplierRange;

		[SerializeField]
		private Vector2 motionDelayRange;

		[SerializeField]
		private Vector2 startingSpeedRange;

		[SerializeField]
		private Vector2 startingScale;

		private Vector3 currentSpeed;

		private float motionDelay;

		private float dampening;

		private float accelerationMultiplier;

		private float t;

		private float scaleSpeed;

		public Transform Target { get; private set; }

		private void Update()
		{
		}

		public void SetTarget(Transform transform)
		{
		}
	}
}
