using UnityEngine;

namespace GearGame.Gameplay
{
	public class LaunchedBowlingBall : MonoBehaviour
	{
		[SerializeField]
		protected AnimationCurve motionCurve;

		[SerializeField]
		protected bool speedBasedMotion;

		[SerializeField]
		protected float tweenMotionTime;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private GameObject spawnPrefab;

		private void Start()
		{
		}
	}
}
