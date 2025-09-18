using System.Runtime.CompilerServices;
using UnityEngine;

namespace Comscore.Streaming
{
	public class StreamingAnalytics : IStreamingAnalytics<StreamingConfiguration, StreamingExtendedAnalytics, StreamingPublisherConfiguration, ContentMetadata, AdvertisementMetadata>
	{
		private class GlobalStreamingAnalyticsListenerJavaProxy : AndroidJavaProxy
		{
			private const string listenerInterfaceWorkaroundJavaClassName = "com.comscore.unity.workaround.StreamingWorkaround$StreamingWorkaroundListener";

			private const string workaroundClassName = "com.comscore.unity.workaround.StreamingWorkaround";

			private StreamingAnalytics Sta { get; }

			internal GlobalStreamingAnalyticsListenerJavaProxy(StreamingAnalytics sta)
				: base((string)null)
			{
			}

			public void onStateChanged(int oldState, int newState, AndroidJavaObject eventLabels)
			{
			}

			internal static void AttatchListener(StreamingAnalytics streamingAnalytics)
			{
			}
		}

		private const string javaClassName = "com.comscore.streaming.StreamingAnalytics";

		private readonly AndroidJavaObject javaInstance;

		private bool registeredGLobalStreamingAnalyticsListener;

		public StreamingExtendedAnalytics ExtendedAnalytics { get; }

		public StreamingConfiguration Configuration { get; }

		public string PlaybackSessionId => null;

		private event OnListener BridgedListener
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

		public event OnListener OnListener
		{
			add
			{
			}
			remove
			{
			}
		}

		public StreamingAnalytics()
		{
		}

		public StreamingAnalytics(StreamingConfiguration configuration)
		{
		}

		public void CreatePlaybackSession()
		{
		}

		public void LoopPlaybackSession()
		{
		}

		public void NotifyBufferStart()
		{
		}

		public void NotifyBufferStop()
		{
		}

		public void NotifyChangePlaybackRate(float newRate)
		{
		}

		public void NotifyEnd()
		{
		}

		public void NotifyPause()
		{
		}

		public void NotifyPlay()
		{
		}

		public void NotifySeekStart()
		{
		}

		public void SetDvrWindowLength(long newDvrWindowLength)
		{
		}

		public void SetImplementationId(string implementationId)
		{
		}

		public void SetMediaPlayerName(string mediaPlayerName)
		{
		}

		public void SetMediaPlayerVersion(string mediaPlayerVersion)
		{
		}

		public void SetProjectId(string projectId)
		{
		}

		public void StartFromDvrWindowOffset(long newDvrWindowOffset)
		{
		}

		public void StartFromPosition(long position)
		{
		}

		public void StartFromSegment(int segmentNumber)
		{
		}

		public void SetMetadata(ContentMetadata metadata)
		{
		}

		public void SetMetadata(AdvertisementMetadata metadata)
		{
		}
	}
}
