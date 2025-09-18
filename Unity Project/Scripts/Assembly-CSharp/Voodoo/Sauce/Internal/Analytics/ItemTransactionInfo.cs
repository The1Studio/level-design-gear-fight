using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public struct ItemTransactionInfo
	{
		public Enum itemName;

		public ItemType itemType;

		public ItemTransactionInfo(Enum name, ItemType type)
		{
			itemName = null;
			itemType = default(ItemType);
		}
	}
}
