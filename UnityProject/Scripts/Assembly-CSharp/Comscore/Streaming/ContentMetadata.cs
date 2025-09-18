using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class ContentMetadata : IContentMetadata
	{
		public class Builder : IContentMetadataBuilder<Builder, ContentMetadata, StackedContentMetadata>
		{
			private const string javaClassName = "com.comscore.streaming.ContentMetadata$Builder";

			private AndroidJavaObject JavaInstance { get; }

			public ContentMetadata Build()
			{
				return null;
			}

			public Builder CarryTvAdvertisementLoad(bool carriesTvAdvertisementLoad)
			{
				return null;
			}

			public Builder ClassifyAsAudioStream(bool classifiedAsAudioStream)
			{
				return null;
			}

			public Builder ClassifyAsCompleteEpisode(bool classifiedAsCompleteEpisode)
			{
				return null;
			}

			public Builder ClipUrl(string clipUrl)
			{
				return null;
			}

			public Builder CustomLabels(Dictionary<string, string> newCustomLabels)
			{
				return null;
			}

			public Builder DateOfDigitalAiring(int year, int month, int day)
			{
				return null;
			}

			public Builder DateOfProduction(int year, int month, int day)
			{
				return null;
			}

			public Builder DateOfTvAiring(int year, int month, int day)
			{
				return null;
			}

			public Builder DeliveryAdvertisementCapability(ContentDeliveryAdvertisementCapability contentDeliveryAdvertisementCapability)
			{
				return null;
			}

			public Builder DeliveryComposition(ContentDeliveryComposition contentDeliveryComposition)
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

			public Builder DistributionModel(ContentDistributionModel contentDistributionModel)
			{
				return null;
			}

			public Builder EpisodeId(string episodeId)
			{
				return null;
			}

			public Builder EpisodeNumber(string episodeNumber)
			{
				return null;
			}

			public Builder EpisodeSeasonNumber(string episodeSeasonNumber)
			{
				return null;
			}

			public Builder EpisodeTitle(string episodeTitle)
			{
				return null;
			}

			public Builder Fee(int fee)
			{
				return null;
			}

			public Builder FeedType(ContentFeedType feedType)
			{
				return null;
			}

			public Builder GenreId(string genreId)
			{
				return null;
			}

			public Builder GenreName(string genreName)
			{
				return null;
			}

			public Builder Length(long length)
			{
				return null;
			}

			public Builder MediaFormat(ContentMediaFormat contentMediaFormat)
			{
				return null;
			}

			public Builder MediaType(ContentType contentType)
			{
				return null;
			}

			public Builder NetworkAffiliate(string networkAffiliate)
			{
				return null;
			}

			public Builder PlaylistTitle(string playlistTitle)
			{
				return null;
			}

			public Builder ProgramId(string programId)
			{
				return null;
			}

			public Builder ProgramTitle(string programTitle)
			{
				return null;
			}

			public Builder PublisherName(string publisherName)
			{
				return null;
			}

			public Builder SetStack(string publisherId, StackedContentMetadata stack)
			{
				return null;
			}

			public Builder StationCode(string stationCode)
			{
				return null;
			}

			public Builder StationTitle(string stationTitle)
			{
				return null;
			}

			public Builder TimeOfDigitalAiring(int hours, int minutes)
			{
				return null;
			}

			public Builder TimeOfProduction(int hours, int minutes)
			{
				return null;
			}

			public Builder TimeOfTvAiring(int hours, int minutes)
			{
				return null;
			}

			public Builder TotalSegments(int totalSegments)
			{
				return null;
			}

			public Builder UniqueId(string contentUniqueId)
			{
				return null;
			}

			public Builder VideoDimensions(int width, int height)
			{
				return null;
			}
		}

		internal AndroidJavaObject JavaInstance { get; }

		private ContentMetadata(AndroidJavaObject javaInstance)
		{
		}
	}
}
