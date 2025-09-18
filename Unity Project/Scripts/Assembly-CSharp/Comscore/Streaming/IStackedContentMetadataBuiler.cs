using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IStackedContentMetadataBuiler<B, P> where B : IStackedContentMetadataBuiler<B, P> where P : IStackedContentMetadata
	{
		P Build();

		B CustomLabels(Dictionary<string, string> newCustomLabels);

		B UniqueId(string contentUniqueId);

		B PublisherName(string publisherName);

		B ProgramTitle(string programTitle);

		B EpisodeTitle(string episodeTitle);

		B EpisodeSeasonNumber(string episodeSeasonNumber);

		B EpisodeNumber(string episodeNumber);

		B GenreName(string genreName);

		B GenreId(string genreId);

		B DateOfProduction(int year, int month, int day);

		B TimeOfProduction(int hours, int minutes);

		B DateOfDigitalAiring(int year, int month, int day);

		B TimeOfDigitalAiring(int hours, int minutes);

		B DateOfTvAiring(int year, int month, int day);

		B TimeOfTvAiring(int hours, int minutes);

		B StationTitle(string stationTitle);

		B StationCode(string stationCode);

		B ProgramId(string programId);

		B EpisodeId(string episodeId);

		B NetworkAffiliate(string networkAffiliate);

		B Fee(int fee);

		B PlaylistTitle(string playlistTitle);

		B DictionaryClassificationC3(string dictionaryClassificationC3);

		B DictionaryClassificationC4(string dictionaryClassificationC4);

		B DictionaryClassificationC6(string dictionaryClassificationC6);

		B DeliveryMode(ContentDeliveryMode contentDeliveryMode);

		B DeliverySubscriptionType(ContentDeliverySubscriptionType contentDeliverySubscriptionType);

		B DeliveryComposition(ContentDeliveryComposition contentDeliveryComposition);

		B DeliveryAdvertisementCapability(ContentDeliveryAdvertisementCapability contentDeliveryAdvertisementCapability);

		B DistributionModel(ContentDistributionModel contentDistributionModel);

		B MediaFormat(ContentMediaFormat contentMediaFormat);
	}
}
