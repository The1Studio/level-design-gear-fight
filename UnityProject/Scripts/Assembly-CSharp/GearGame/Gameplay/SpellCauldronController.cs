using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellCauldronController : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] explosionObjects;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float jumpTimer;

		[SerializeField]
		private float areaOfEffect;

		private Vector2 lastPosition;

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
