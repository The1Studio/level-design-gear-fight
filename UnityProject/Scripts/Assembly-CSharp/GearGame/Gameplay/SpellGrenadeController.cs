using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellGrenadeController : MonoBehaviour
	{
		[SerializeField]
		private GameObject explosionObject;

		[SerializeField]
		private float areaOfEffect;

		[SerializeField]
		private AudioSource groundImpactSource;

		[SerializeField]
		private AnimationCurve firstCurve;

		[SerializeField]
		private float firstTime;

		[SerializeField]
		private float firstJumpHeight;

		[SerializeField]
		private AnimationCurve secondCurve;

		[SerializeField]
		private float secondTime;

		[SerializeField]
		private float secondJumpHeight;

		private void Start()
		{
		}

		private void Explode()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
