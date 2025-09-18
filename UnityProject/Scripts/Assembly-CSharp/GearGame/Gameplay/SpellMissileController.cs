using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellMissileController : MonoBehaviour
	{
		[SerializeField]
		private float areaOfEffectRange;

		[SerializeField]
		private float movementSpeed;

		[SerializeField]
		private float rotationZ;

		[SerializeField]
		private float rotationX;

		[SerializeField]
		private float rotationY;

		[SerializeField]
		private float scalerAdder;

		[SerializeField]
		private ParticleSystem rocketSystem;

		[SerializeField]
		private GameObject explosionObject;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private AnimationCurve rotationCurve;

		private void Start()
		{
		}

		private void Explode()
		{
		}
	}
}
