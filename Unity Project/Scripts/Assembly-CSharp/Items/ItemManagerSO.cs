using UnityEngine;
using VInspector;

namespace Items
{
	[CreateAssetMenu(menuName = "Items/Manager")]
	public class ItemManagerSO : ScriptableObject
	{
		public ItemSO[] Items;

		public ItemSystem[] Systems;

		public SerializedDictionary<string, ItemNames> NameToId;
	}
}
