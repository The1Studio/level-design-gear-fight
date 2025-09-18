namespace Items
{
	public struct DropInfos
	{
		public DropRange Amount;

		public float Percentage;

		public RaritySO Rarity;

		public ItemSO Item;

		public DropInfos(ItemSO item, DropRange amount, float percentage, RaritySO rarity)
		{
			Amount = default(DropRange);
			Percentage = 0f;
			Rarity = null;
			Item = null;
		}
	}
}
