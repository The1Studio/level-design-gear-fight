namespace Voodoo.Live.Offers
{
	public class ServerOffer : ServerFeature, IServerFeature
	{
		public Reward reward;

		public IPrice price;

		public override IFeature ToValidFormat()
		{
			return null;
		}
	}
}
