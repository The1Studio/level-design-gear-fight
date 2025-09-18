using System.Collections.Generic;

namespace Comscore
{
	internal interface IConfiguration<CliConf, PubConf, ParConf> where CliConf : IClientConfiguration where PubConf : IPublisherConfiguration where ParConf : IPartnerConfiguration
	{
		string[] LabelOrder { get; set; }

		event OnCrossPublisherUniqueDeviceIdChangeDelegate OnCrossPublisherUniqueDeviceIdChange;

		void AddClient(CliConf client);

		void SetPersistentLabel(string name, string value);

		void RemoveAllPersistentLabels();

		void RemovePersistentLabel(string name);

		void AddPersistentLabels(Dictionary<string, string> labels);

		void SetStartLabel(string name, string value);

		void RemoveAllStartLabels();

		void RemoveStartLabel(string name);

		void AddStartLabels(Dictionary<string, string> labels);

		ParConf GetPartnerConfiguration(string partnerId);

		PubConf GetPublisherConfiguration(string publisherId);

		List<PubConf> GetPublisherConfigurations();

		List<ParConf> GetPartnerConfigurations();

		void SetLiveEndpointUrl(string value);

		void SetOfflineFlushEndpointUrl(string value);

		void SetApplicationName(string value);

		void SetApplicationVersion(string value);

		void SetApplicationId(string value);

		void SetSystemClockJumpDetectionEnabled(bool value);

		void SetSystemClockJumpDetectionInterval(long value);

		void SetSystemClockJumpDetectionPrecision(long value);

		void SetKeepAliveMeasurementEnabled(bool value);

		void SetUsagePropertiesAutoUpdateInterval(int value);

		void SetCacheMaxMeasurements(int value);

		void SetCacheMaxBatchFiles(int value);

		void SetCacheMaxFlushesInARow(int value);

		void SetCacheMinutesToRetry(int value);

		void SetCacheMeasurementExpiry(int value);

		bool IsEnabled();

		void Disable();

		void EnableImplementationValidationMode();

		void AddIncludedPublisher(string publisherId);

		void SetLiveTransmissionMode(LiveTransmissionMode value);

		void EnableChildDirectedApplicationMode();

		void DisableTfcIntegration();
	}
}
