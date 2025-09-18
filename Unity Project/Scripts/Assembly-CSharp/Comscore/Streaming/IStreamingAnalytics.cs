namespace Comscore.Streaming
{
	internal interface IStreamingAnalytics<SConf, ExAna, StrPubConf, ContMeta, AdMeta> where SConf : IStreamingConfiguration<StrPubConf> where ExAna : IStreamingExtendedAnalytics where StrPubConf : IStreamingPublisherConfiguration where ContMeta : IContentMetadata where AdMeta : IAdvertisementMetadata
	{
		ExAna ExtendedAnalytics { get; }

		SConf Configuration { get; }

		string PlaybackSessionId { get; }

		event OnListener OnListener;

		void CreatePlaybackSession();

		void StartFromPosition(long position);

		void NotifyPlay();

		void NotifyPause();

		void NotifyEnd();

		void NotifyBufferStart();

		void NotifyBufferStop();

		void NotifySeekStart();

		void NotifyChangePlaybackRate(float newRate);

		void SetDvrWindowLength(long newDvrWindowLength);

		void StartFromDvrWindowOffset(long newDvrWindowOffset);

		void SetMediaPlayerName(string mediaPlayerName);

		void SetMediaPlayerVersion(string mediaPlayerVersion);

		void SetMetadata(ContMeta metadata);

		void SetMetadata(AdMeta metadata);

		void SetImplementationId(string implementationId);

		void SetProjectId(string projectId);

		void StartFromSegment(int segmentNumber);

		void LoopPlaybackSession();
	}
}
