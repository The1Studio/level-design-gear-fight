using NaughtyAttributes;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SimpleAttackCameraPositioner : MonoBehaviour
	{
		[SerializeField]
		private bool centerX;

		[SerializeField]
		private bool centerY;

		[SerializeField]
		private bool forcePositionY;

		[ShowIf("forcePositionY")]
		[SerializeField]
		private float forcedYPosition;

		private void Start()
		{
		}
	}
}
