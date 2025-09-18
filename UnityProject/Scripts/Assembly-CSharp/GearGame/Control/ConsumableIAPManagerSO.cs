using Data.Shop;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "IAP/Consumable IAP Manager")]
	public class ConsumableIAPManagerSO : ScriptableObject
	{
		[field: SerializeField]
		public ShopItemMetaBase[] AllManagedProducts { get; private set; }
	}
}
