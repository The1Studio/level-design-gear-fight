using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Comscore
{
	public class Configuration : IConfiguration<ClientConfiguration, PublisherConfiguration, PartnerConfiguration>
	{
		private class CrossPublisherUniqueDeviceIdChangeListenerJavaProxy : AndroidJavaProxy
		{
			private readonly Configuration bridgedConfiguration;

			private const string listenerInterfaceWorkaroundJavaClassName = "com.comscore.unity.workaround.CrossPublisherUniqueDeviceIdChangeWorkaround$CrossPublisherUniqueDeviceIdChangeWorkaroundListener";

			private const string workaroundClassName = "com.comscore.unity.workaround.CrossPublisherUniqueDeviceIdChangeWorkaround";

			public CrossPublisherUniqueDeviceIdChangeListenerJavaProxy(Configuration bridgedConfiguration)
				: base((string)null)
			{
			}

			public void onCrossPublisherUniqueDeviceIdChanged(string crossPublisherId)
			{
			}

			internal static void AttatchListener(Configuration configuration)
			{
			}
		}

		private readonly AndroidJavaObject javaInstance;

		private bool registedCrossPublisherUniqueDeviceIdChangeListener;

		public string[] LabelOrder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private event OnCrossPublisherUniqueDeviceIdChangeDelegate onCrossPublisherUniqueDeviceIdChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnCrossPublisherUniqueDeviceIdChangeDelegate OnCrossPublisherUniqueDeviceIdChange
		{
			add
			{
			}
			remove
			{
			}
		}

		internal Configuration(AndroidJavaObject androidJavaObject)
		{
		}

		public void AddClient(ClientConfiguration client)
		{
		}

		public void SetPersistentLabel(string name, string value)
		{
		}

		public void RemoveAllPersistentLabels()
		{
		}

		public void RemovePersistentLabel(string name)
		{
		}

		public void AddPersistentLabels(Dictionary<string, string> labels)
		{
		}

		public void SetStartLabel(string name, string value)
		{
		}

		public void RemoveAllStartLabels()
		{
		}

		public void RemoveStartLabel(string name)
		{
		}

		public void AddStartLabels(Dictionary<string, string> labels)
		{
		}

		public PartnerConfiguration GetPartnerConfiguration(string partnerId)
		{
			return null;
		}

		public PublisherConfiguration GetPublisherConfiguration(string publisherId)
		{
			return null;
		}

		public List<PublisherConfiguration> GetPublisherConfigurations()
		{
			return null;
		}

		public List<PartnerConfiguration> GetPartnerConfigurations()
		{
			return null;
		}

		public void SetLiveEndpointUrl(string value)
		{
		}

		public void SetOfflineFlushEndpointUrl(string value)
		{
		}

		public void SetApplicationName(string value)
		{
		}

		public void SetApplicationVersion(string value)
		{
		}

		public void SetApplicationId(string value)
		{
		}

		public void SetSystemClockJumpDetectionEnabled(bool value)
		{
		}

		public void SetSystemClockJumpDetectionInterval(long value)
		{
		}

		public void SetSystemClockJumpDetectionPrecision(long value)
		{
		}

		public void SetKeepAliveMeasurementEnabled(bool value)
		{
		}

		public void SetUsagePropertiesAutoUpdateInterval(int value)
		{
		}

		public void SetCacheMaxMeasurements(int value)
		{
		}

		public void SetCacheMaxBatchFiles(int value)
		{
		}

		public void SetCacheMaxFlushesInARow(int value)
		{
		}

		public void SetCacheMinutesToRetry(int value)
		{
		}

		public void SetCacheMeasurementExpiry(int value)
		{
		}

		public bool IsEnabled()
		{
			return false;
		}

		public void Disable()
		{
		}

		public void EnableImplementationValidationMode()
		{
		}

		public void AddIncludedPublisher(string publisherId)
		{
		}

		public void SetLiveTransmissionMode(LiveTransmissionMode value)
		{
		}

		public void EnableChildDirectedApplicationMode()
		{
		}

		public void DisableTfcIntegration()
		{
		}
	}
}
