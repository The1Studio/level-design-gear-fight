using Voodoo.Live.Offers;

namespace Voodoo.Live.Analytics
{
	public class OfferListener : FeatureListener
	{
		private Offer _offer;

		protected override string LastTrigger => null;

		protected override string ShownSubFeature => null;

		protected override IFeature ClickedFeature => null;

		public OfferListener(Offer offer)
			: base(null)
		{
		}
	}
}
