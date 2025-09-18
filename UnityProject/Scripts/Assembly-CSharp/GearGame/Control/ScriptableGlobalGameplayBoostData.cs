using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Global Gameplay Boost")]
	public class ScriptableGlobalGameplayBoostData : ScriptableObject
	{
		[field: SerializeField]
		public int DurationInSeconds { get; private set; }

		[field: SerializeField]
		public string ID { get; private set; }

		[field: SerializeField]
		public string DescriptionLocalizationKey { get; private set; }

		[field: SerializeField]
		public string DescriptionLocalizationShortKey { get; private set; }

		[field: SerializeField]
		public Sprite DisplaySprite { get; private set; }
	}
}
