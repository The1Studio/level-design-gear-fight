using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class AdvertisementMetadata : IAdvertisementMetadata
	{
		public class Builder : IAdvertisementMetadataBuilder<Builder, AdvertisementMetadata, StackedAdvertisementMetadata, ContentMetadata>
		{
			private const string javaClassName = "com.comscore.streaming.AdvertisementMetadata$Builder";

			private AndroidJavaObject JavaInstance { get; }

			public AdvertisementMetadata Build()
			{
				return null;
			}

			public Builder SetStack(string publisherId, StackedAdvertisementMetadata stack)
			{
				return null;
			}

			public Builder CustomLabels(Dictionary<string, string> newCustomLabels)
			{
				return null;
			}

			public Builder RelatedContentMetadata(ContentMetadata contentMetadata)
			{
				return null;
			}

			public Builder MediaType(AdvertisementType advertisementType)
			{
				return null;
			}

			public Builder ClassifyAsAudioStream(bool classifiedAsAudioStream)
			{
				return null;
			}

			public Builder VideoDimensions(int width, int height)
			{
				return null;
			}

			public Builder Length(long length)
			{
				return null;
			}

			public Builder Fee(int fee)
			{
				return null;
			}

			public Builder ClipUrl(string clipUrl)
			{
				return null;
			}

			public Builder BreakNumber(int advertisementBreakNumber)
			{
				return null;
			}

			public Builder TotalBreaks(int totalAdvertisementBreaks)
			{
				return null;
			}

			public Builder NumberInBreak(int advertisementNumberInBreak)
			{
				return null;
			}

			public Builder TotalInBreak(int totalAdvertisementsInBreak)
			{
				return null;
			}

			public Builder UniqueId(string advertisementUniqueId)
			{
				return null;
			}

			public Builder Title(string advertisementTitle)
			{
				return null;
			}

			public Builder Server(string advertisementServer)
			{
				return null;
			}

			public Builder CallToActionUrl(string advertisementCallToActionUrl)
			{
				return null;
			}

			public Builder ServerCampaignId(string advertisementServerCampaignId)
			{
				return null;
			}

			public Builder PlacementId(string advertisementPlacementId)
			{
				return null;
			}

			public Builder SiteId(string siteId)
			{
				return null;
			}

			public Builder DeliveryType(AdvertisementDeliveryType advertisementDeliveryType)
			{
				return null;
			}

			public Builder Owner(AdvertisementOwner advertisementOwner)
			{
				return null;
			}
		}

		internal AndroidJavaObject JavaInstance { get; }

		private AdvertisementMetadata(AndroidJavaObject javaInstance)
		{
		}
	}
}
