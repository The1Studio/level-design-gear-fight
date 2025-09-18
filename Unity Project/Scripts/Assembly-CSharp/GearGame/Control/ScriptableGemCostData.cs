using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Gem Costs")]
	public class ScriptableGemCostData : ScriptableObject
	{
		[field: SerializeField]
		public int PackWeakCost { get; private set; }

		[field: SerializeField]
		public int SmallBlueCoinsPackCost { get; private set; }

		[field: SerializeField]
		public int LargeBlueCoinsPackCost { get; private set; }

		[field: SerializeField]
		public int SmallGreenCoinsPackCost { get; private set; }

		[field: SerializeField]
		public int LargeGreenCoinsPackCost { get; private set; }
	}
}
