using UnityEngine;

namespace GearGame.Gameplay.Misc
{
	public class ShadowProjector : MonoBehaviour
	{
		public const float ScaleUnitPerYOffset = 0.25f;

		[SerializeField]
		private Transform shadowTransform;

		[SerializeField]
		private Transform trackingTransform;

		[SerializeField]
		private bool initializeOnStart;

		private Vector3 startingScale;

		private float yPosition;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void AddY(float amount)
		{
		}

		public void SetYPosition(float yPosition)
		{
		}

		public void SetStartingScale()
		{
		}
	}
}
