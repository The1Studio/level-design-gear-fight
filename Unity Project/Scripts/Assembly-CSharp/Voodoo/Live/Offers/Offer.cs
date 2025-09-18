namespace Voodoo.Live.Offers
{
	public class Offer : Feature, IFeature, IConditionnal
	{
		public Reward reward;

		private IPurchasable _price;

		public IPurchasable Price
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool IsDataValid => false;

		public override Reward GetReward()
		{
			return null;
		}

		public override void SetupItems(Item[] items)
		{
		}

		public override Transaction ToTransaction()
		{
			return null;
		}
	}
}
