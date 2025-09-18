using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class StackedContentMetadata : IStackedContentMetadata
	{
		public class Builder : IStackedContentMetadataBuiler<Builder, StackedContentMetadata>
		{
			private const string javaClassName = "com.comscore.streaming.StackedContentMetadata$Builder";

			private AndroidJavaObject JavaInstance { get; }

			public StackedContentMetadata Build()
			{
				return null;
			}

			public Builder CustomLabels(Dictionary<string, string> newCustomLabels)
			{
				return null;
			}

			public Builder UniqueId(string contentUniqueId)
			{
				return null;
			}

			public Builder PublisherName(string publisherName)
			{
				return null;
			}

			public Builder ProgramTitle(string programTitle)
			{
				return null;
			}

			public Builder EpisodeTitle(string episodeTitle)
			{
				return null;
			}

			public Builder EpisodeSeasonNumber(string episodeSeasonNumber)
			{
				return null;
			}

			public Builder EpisodeNumber(string episodeNumber)
			{
				return null;
			}

			public Builder GenreName(string genreName)
			{
				return null;
			}

			public Builder GenreId(string genreId)
			{
				return null;
			}

			public Builder DateOfProduction(int year, int month, int day)
			{
				return null;
			}

			public Builder TimeOfProduction(int hours, int minutes)
			{
				return null;
			}

			public Builder DateOfDigitalAiring(int year, int month, int day)
			{
				return null;
			}

			public Builder TimeOfDigitalAiring(int hours, int minutes)
			{
				return null;
			}

			public Builder DateOfTvAiring(int year, int month, int day)
			{
				return null;
			}

			public Builder TimeOfTvAiring(int hours, int minutes)
			{
				return null;
			}

			public Builder StationTitle(string stationTitle)
			{
				return null;
			}

			public Builder StationCode(string stationCode)
			{
				return null;
			}

			public Builder ProgramId(string programId)
			{
				return null;
			}

			public Builder EpisodeId(string episodeId)
			{
				return null;
			}

			public Builder NetworkAffiliate(string networkAffiliate)
			{
				return null;
			}

			public Builder Fee(int fee)
			{
				return null;
			}

			public Builder PlaylistTitle(string playlistTitle)
			{
				return null;
			}

			public Builder DictionaryClassificationC3(string dictionaryClassificationC3)
			{
				return null;
			}

			public Builder DictionaryClassificationC4(string dictionaryClassificationC4)
			{
				return null;
			}

			public Builder DictionaryClassificationC6(string dictionaryClassificationC6)
			{
				return null;
			}

			public Builder DeliveryMode(ContentDeliveryMode contentDeliveryMode)
			{
				return null;
			}

			public Builder DeliverySubscriptionType(ContentDeliverySubscriptionType contentDeliverySubscriptionType)
			{
				return null;
			}

			public Builder DeliveryComposition(ContentDeliveryComposition contentDeliveryComposition)
			{
				return null;
			}

			public Builder DeliveryAdvertisementCapability(ContentDeliveryAdvertisementCapability contentDeliveryAdvertisementCapability)
			{
				return null;
			}

			public Builder DistributionModel(ContentDistributionModel contentDistributionModel)
			{
				return null;
			}

			public Builder MediaFormat(ContentMediaFormat contentMediaFormat)
			{
				return null;
			}
		}

		internal AndroidJavaObject JavaInstance { get; }

		private StackedContentMetadata(AndroidJavaObject javaInstance)
		{
		}
	}
}
