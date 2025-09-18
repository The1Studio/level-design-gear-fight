using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearTroopSpawnerReferenceContainer : MonoBehaviour
	{
		[field: SerializeField]
		public SpriteRenderer[] DisplaySprites { get; set; }
	}
}
