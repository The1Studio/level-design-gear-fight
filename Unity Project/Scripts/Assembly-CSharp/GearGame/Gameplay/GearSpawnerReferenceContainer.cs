using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearSpawnerReferenceContainer : MonoBehaviour
	{
		[field: SerializeField]
		public GameObject SpawnObject { get; set; }

		[field: SerializeField]
		public SpriteRenderer FillSprite { get; set; }

		[field: SerializeField]
		public GameObject ValueDisplayRoot { get; private set; }

		[field: SerializeField]
		public Animator ValueDisplayAnimator { get; private set; }

		[field: SerializeField]
		public Transform SpawnTransform { get; private set; }

		[field: SerializeField]
		public AudioSourceVariable SpawnSource { get; private set; }

		[field: SerializeField]
		public TextMeshPro ValueDisplayText { get; private set; }

		[field: SerializeField]
		public GameObject LockObject { get; private set; }
	}
}
