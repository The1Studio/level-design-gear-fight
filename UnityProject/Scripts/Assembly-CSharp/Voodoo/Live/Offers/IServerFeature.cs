namespace Voodoo.Live.Offers
{
	public interface IServerFeature
	{
		string id { get; set; }

		string name { get; set; }

		string techName { get; set; }

		string[] triggers { get; set; }

		int multiplier { get; set; }

		string campaign { get; set; }

		bool showCountdown { get; set; }

		string badgeIcon { get; set; }

		bool displayMenuBadge { get; set; }

		string offerImage { get; set; }

		string title { get; set; }

		bool showBadgeCountdown { get; set; }

		string[] highlightTexts { get; set; }

		OfferConditions offerConditions { get; set; }

		string type { get; set; }

		IFeature ToValidFormat();
	}
}
