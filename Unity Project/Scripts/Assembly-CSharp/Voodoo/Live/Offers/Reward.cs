namespace Voodoo.Live.Offers
{
	public class Reward
	{
		public string hashId { get; set; }

		public ItemToQuantity[] items { get; set; }

		public void SetupItems(Item[] fullItems)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
