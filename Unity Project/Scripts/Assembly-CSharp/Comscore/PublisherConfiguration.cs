using UnityEngine;

namespace Comscore
{
	public class PublisherConfiguration : ClientConfiguration, IPublisherConfiguration, IClientConfiguration
	{
		public new class Builder : Builder<Builder, PublisherConfiguration>, IPublisherConfigurationBuilder<Builder, PublisherConfiguration>, IClientConfigurationBuilder<Builder, PublisherConfiguration>
		{
			private class PublisherUniqueDeviceIdListenerJavaProxy : AndroidJavaProxy
			{
				private const string interfaceWorkaroundJavaClassName = "com.comscore.unity.workaround.PublisherUniqueDeviceIdBridgeWorkaround$PublisherUniqueDeviceIdBridgeWorkaroundListener";

				private const string workaroundClassName = "com.comscore.unity.workaround.PublisherUniqueDeviceIdBridgeWorkaround";

				private readonly OnPublisherUniqueDeviceIdDelegate listener;

				private readonly Builder Builder;

				public PublisherUniqueDeviceIdListenerJavaProxy(OnPublisherUniqueDeviceIdDelegate listener, Builder builder)
					: base((string)null)
				{
				}

				public void onPublisherUniqueDeviceIdAvailable(string publisherId, string publisherUniqueDeviceId)
				{
				}

				internal static void AttatchListener(Builder builder, OnPublisherUniqueDeviceIdDelegate listener)
				{
				}
			}

			private const string className = "com.comscore.PublisherConfiguration$Builder";

			public Builder()
				: base((AndroidJavaObject)null)
			{
			}

			protected override Builder Self()
			{
				return null;
			}

			public override PublisherConfiguration Build()
			{
				return null;
			}

			public Builder PublisherId(string publisherId)
			{
				return null;
			}

			public Builder PublisherUniqueDeviceIdListener(OnPublisherUniqueDeviceIdDelegate listener)
			{
				return null;
			}
		}

		internal PublisherConfiguration(AndroidJavaObject javaInstance)
			: base(null)
		{
		}
	}
}
