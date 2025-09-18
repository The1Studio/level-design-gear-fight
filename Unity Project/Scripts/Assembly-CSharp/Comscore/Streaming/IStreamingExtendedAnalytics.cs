using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IStreamingExtendedAnalytics
	{
		void NotifyLoad();

		void NotifyLoad(Dictionary<string, string> labels);

		void NotifyEngage(Dictionary<string, string> labels);

		void NotifyEngage();

		void NotifySkipAd(Dictionary<string, string> labels);

		void NotifySkipAd();

		void NotifyCallToAction(Dictionary<string, string> labels);

		void NotifyCallToAction();

		void NotifyError(string errorIdentifier, Dictionary<string, string> labels);

		void NotifyError(string errorIdentifier);

		void NotifyTransferPlayback(string targetDevice);

		void NotifyTransferPlayback(string targetDevice, Dictionary<string, string> labels);

		void NotifyDrmFail(Dictionary<string, string> labels);

		void NotifyDrmFail();

		void NotifyDrmApprove(Dictionary<string, string> labels);

		void NotifyDrmApprove();

		void NotifyDrmDeny();

		void NotifyDrmDeny(Dictionary<string, string> labels);

		void NotifyChangeBitrate(int newRate);

		void NotifyChangeBitrate(int newRate, Dictionary<string, string> labels);

		void NotifyChangeWindowState(WindowState newState, Dictionary<string, string> labels);

		void NotifyChangeWindowState(WindowState newState);

		void NotifyChangeAudioTrack(string newAudio);

		void NotifyChangeAudioTrack(string newAudio, Dictionary<string, string> labels);

		void NotifyChangeVideoTrack(string newVideo);

		void NotifyChangeVideoTrack(string newVideo, Dictionary<string, string> labels);

		void NotifyChangeSubtitleTrack(string newSubtitle);

		void NotifyChangeSubtitleTrack(string newSubtitle, Dictionary<string, string> labels);

		void NotifyCustomEvent(string eventName);

		void NotifyCustomEvent(string eventName, Dictionary<string, string> labels);

		void SetPlaybackSessionExpectedLength(long expectedTotalLength);

		void SetPlaybackSessionExpectedNumberOfItems(int expectedNumberOfItems);

		void NotifyChangeVolume(float newVolume);

		void NotifyChangeVolume(float newVolume, Dictionary<string, string> labels);

		void NotifyChangeCdn(string newCDN);

		void NotifyChangeCdn(string newCDN, Dictionary<string, string> labels);

		void SetLoadTimeOffset(long offset);
	}
}
