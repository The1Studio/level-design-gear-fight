using System.Collections.Generic;
using UnityEngine;
using Voodoo.Live.Offers;

namespace Voodoo.Live.Sample.Offers.UI
{
	public class OfferBadgesManagerUI : MonoBehaviour
	{
		[SerializeField]
		private Transform _offerBadgesContainer;

		private List<OfferBadgeUI> _offerBadges;

		public void Init(OfferBadgeUI[] badges, List<IFeature> features)
		{
		}

		private void OnEnable()
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
