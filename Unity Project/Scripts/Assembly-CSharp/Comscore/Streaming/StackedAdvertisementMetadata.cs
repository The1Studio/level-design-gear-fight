using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class StackedAdvertisementMetadata : IStackedAdvertisementMetadata
	{
		public class Builder : IStackedAdvertisementMetadataBuiler<Builder, StackedAdvertisementMetadata>
		{
			private const string javaClassName = "com.comscore.streaming.StackedAdvertisementMetadata$Builder";

			private AndroidJavaObject JavaInstance { get; }

			public StackedAdvertisementMetadata Build()
			{
				return null;
			}

			public Builder CustomLabels(Dictionary<string, string> newCustomLabels)
			{
				return null;
			}

			public Builder Fee(int fee)
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
		}

		internal AndroidJavaObject JavaInstance { get; }

		private StackedAdvertisementMetadata(AndroidJavaObject javaInstance)
		{
		}
	}
}
