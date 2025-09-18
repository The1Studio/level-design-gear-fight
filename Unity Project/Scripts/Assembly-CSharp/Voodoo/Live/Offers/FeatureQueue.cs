using System.Collections.Generic;
using Voodoo.Live.Sample.Offers.UI;

namespace Voodoo.Live.Offers
{
	public class FeatureQueue
	{
		private readonly Queue<IFeature> _queue;

		private bool _hasFeatureDisplayed;

		private OfferBadgesManagerUI _offerBadgesManager;

		public void Initialize(List<IFeature> offers)
		{
		}

		private void OnFeatureStatusChanged(string status, IFeature feature)
		{
		}

		private void OnClose()
		{
		}

		private void OnTrigger(IFeature feature)
		{
		}

		private void ShowNextFeature()
		{
		}

		public void ShowAllBadges()
		{
		}

		public void HideAllBadges()
		{
		}
	}
}
