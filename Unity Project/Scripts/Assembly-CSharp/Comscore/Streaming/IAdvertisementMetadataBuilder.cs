using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IAdvertisementMetadataBuilder<B, P, StackAdMet, ContMeta> where B : IAdvertisementMetadataBuilder<B, P, StackAdMet, ContMeta> where P : IAdvertisementMetadata where StackAdMet : IStackedAdvertisementMetadata where ContMeta : IContentMetadata
	{
		P Build();

		B SetStack(string publisherId, StackAdMet stack);

		B CustomLabels(Dictionary<string, string> newCustomLabels);

		B RelatedContentMetadata(ContMeta contentMetadata);

		B MediaType(AdvertisementType advertisementType);

		B ClassifyAsAudioStream(bool classifiedAsAudioStream);

		B VideoDimensions(int width, int height);

		B Length(long length);

		B Fee(int fee);

		B ClipUrl(string clipUrl);

		B BreakNumber(int advertisementBreakNumber);

		B TotalBreaks(int totalAdvertisementBreaks);

		B NumberInBreak(int advertisementNumberInBreak);

		B TotalInBreak(int totalAdvertisementsInBreak);

		B UniqueId(string advertisementUniqueId);

		B Title(string advertisementTitle);

		B Server(string advertisementServer);

		B CallToActionUrl(string advertisementCallToActionUrl);

		B ServerCampaignId(string advertisementServerCampaignId);

		B PlacementId(string advertisementPlacementId);

		B SiteId(string siteId);

		B DeliveryType(AdvertisementDeliveryType advertisementDeliveryType);

		B Owner(AdvertisementOwner advertisementOwner);
	}
}
