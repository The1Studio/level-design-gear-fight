using Data.Shop;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Bulk Offering Collection")]
	public class ScriptableBulkSaleCollection : ScriptableObject
	{
		[field: SerializeField]
		public ShopItemMetaData[] ShopItemData { get; private set; }
	}
}
