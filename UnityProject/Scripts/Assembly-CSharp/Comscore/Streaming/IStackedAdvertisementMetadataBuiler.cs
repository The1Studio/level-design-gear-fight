using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IStackedAdvertisementMetadataBuiler<B, P> where B : IStackedAdvertisementMetadataBuiler<B, P> where P : IStackedAdvertisementMetadata
	{
		P Build();

		B CustomLabels(Dictionary<string, string> newCustomLabels);

		B Fee(int fee);

		B UniqueId(string advertisementUniqueId);

		B Title(string advertisementTitle);

		B ServerCampaignId(string advertisementServerCampaignId);

		B PlacementId(string advertisementPlacementId);

		B SiteId(string siteId);
	}
}
