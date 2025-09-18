using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IStreamingConfigurationBuilder<B, P, StrPubConf> where B : IStreamingConfigurationBuilder<B, P, StrPubConf> where P : IStreamingConfiguration<StrPubConf> where StrPubConf : IStreamingPublisherConfiguration
	{
		P Build();

		B IncludedPublishers(List<string> includedPublishersList);

		B IncludedPublishers(params string[] includedPublishers);

		B PauseOnBuffering(bool enabled);

		B PauseOnBufferingInterval(long pauseOnBufferingInterval);

		B KeepAliveInterval(long keepAliveInterval);

		B KeepAliveMeasurement(bool enabled);

		B HeartbeatIntervals(List<HeartbeatInterval> intervals);

		B HeartbeatMeasurement(bool enabled);

		B Labels(Dictionary<string, string> labels);

		B PlaybackIntervalMergeTolerance(long playbackIntervalMergeTolerance);

		B CustomStartMinimumPlayback(long minimumPlayback);

		B AutoResumeStateOnAssetChange(bool autoResume);
	}
}
