namespace Voodoo.Live.Offers
{
	public class PriceConverter : JsonCreationConverter<IPrice>
	{
		public override IPrice GetTargetInstance(string type)
		{
			return null;
		}
	}
}
