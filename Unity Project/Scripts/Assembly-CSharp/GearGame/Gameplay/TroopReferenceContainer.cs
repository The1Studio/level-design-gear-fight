using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopReferenceContainer : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer displaySprite;

		[SerializeField]
		private GameObject deathObject;

		[SerializeField]
		private GameObject freezeObject;

		public SpriteRenderer DisplaySprite => null;

		public GameObject DeathObject => null;

		public GameObject FreezeObject => null;
	}
}
