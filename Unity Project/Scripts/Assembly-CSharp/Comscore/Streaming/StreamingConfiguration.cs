using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class StreamingConfiguration : IStreamingConfiguration<StreamingPublisherConfiguration>
	{
		public class Builder : IStreamingConfigurationBuilder<Builder, StreamingConfiguration, StreamingPublisherConfiguration>
		{
			private const string javaClassName = "com.comscore.streaming.StreamingConfiguration$Builder";

			internal AndroidJavaObject JavaInstance { get; }

			public StreamingConfiguration Build()
			{
				return null;
			}

			public Builder AutoResumeStateOnAssetChange(bool autoResume)
			{
				return null;
			}

			public Builder CustomStartMinimumPlayback(long minimumPlayback)
			{
				return null;
			}

			public Builder HeartbeatIntervals(List<HeartbeatInterval> intervals)
			{
				return null;
			}

			public Builder HeartbeatMeasurement(bool enabled)
			{
				return null;
			}

			public Builder IncludedPublishers(List<string> includedPublishersList)
			{
				return null;
			}

			public Builder IncludedPublishers(params string[] includedPublishers)
			{
				return null;
			}

			public Builder KeepAliveInterval(long keepAliveInterval)
			{
				return null;
			}

			public Builder KeepAliveMeasurement(bool enabled)
			{
				return null;
			}

			public Builder Labels(Dictionary<string, string> labels)
			{
				return null;
			}

			public Builder PauseOnBuffering(bool enabled)
			{
				return null;
			}

			public Builder PauseOnBufferingInterval(long pauseOnBufferingInterval)
			{
				return null;
			}

			public Builder PlaybackIntervalMergeTolerance(long playbackIntervalMergeTolerance)
			{
				return null;
			}
		}

		internal AndroidJavaObject JavaInstance { get; }

		internal StreamingConfiguration(AndroidJavaObject javaInstance)
		{
		}

		public StreamingPublisherConfiguration GetStreamingPublisherConfiguration(string publisherId)
		{
			return null;
		}

		public void AddLabels(Dictionary<string, string> labels)
		{
		}

		public void RemoveAllLabels()
		{
		}

		public void RemoveLabel(string name)
		{
		}

		public void SetLabel(string name, string value)
		{
		}
	}
}
