using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class StreamingExtendedAnalytics : IStreamingExtendedAnalytics
	{
		internal AndroidJavaObject JavaInstance { get; }

		internal StreamingExtendedAnalytics(AndroidJavaObject javaInstance)
		{
		}

		public void NotifyLoad()
		{
		}

		public void NotifyLoad(Dictionary<string, string> labels)
		{
		}

		public void NotifyEngage(Dictionary<string, string> labels)
		{
		}

		public void NotifyEngage()
		{
		}

		public void NotifySkipAd(Dictionary<string, string> labels)
		{
		}

		public void NotifySkipAd()
		{
		}

		public void NotifyCallToAction(Dictionary<string, string> labels)
		{
		}

		public void NotifyCallToAction()
		{
		}

		public void NotifyError(string errorIdentifier, Dictionary<string, string> labels)
		{
		}

		public void NotifyError(string errorIdentifier)
		{
		}

		public void NotifyTransferPlayback(string targetDevice)
		{
		}

		public void NotifyTransferPlayback(string targetDevice, Dictionary<string, string> labels)
		{
		}

		public void NotifyDrmFail(Dictionary<string, string> labels)
		{
		}

		public void NotifyDrmFail()
		{
		}

		public void NotifyDrmApprove(Dictionary<string, string> labels)
		{
		}

		public void NotifyDrmApprove()
		{
		}

		public void NotifyDrmDeny()
		{
		}

		public void NotifyDrmDeny(Dictionary<string, string> labels)
		{
		}

		public void NotifyChangeBitrate(int newRate)
		{
		}

		public void NotifyChangeBitrate(int newRate, Dictionary<string, string> labels)
		{
		}

		public void NotifyChangeWindowState(WindowState newState, Dictionary<string, string> labels)
		{
		}

		public void NotifyChangeWindowState(WindowState newState)
		{
		}

		public void NotifyChangeAudioTrack(string newAudio)
		{
		}

		public void NotifyChangeAudioTrack(string newAudio, Dictionary<string, string> labels)
		{
		}

		public void NotifyChangeVideoTrack(string newVideo)
		{
		}

		public void NotifyChangeVideoTrack(string newVideo, Dictionary<string, string> labels)
		{
		}

		public void NotifyChangeSubtitleTrack(string newSubtitle)
		{
		}

		public void NotifyChangeSubtitleTrack(string newSubtitle, Dictionary<string, string> labels)
		{
		}

		public void NotifyCustomEvent(string eventName)
		{
		}

		public void NotifyCustomEvent(string eventName, Dictionary<string, string> labels)
		{
		}

		public void SetPlaybackSessionExpectedLength(long expectedTotalLength)
		{
		}

		public void SetPlaybackSessionExpectedNumberOfItems(int expectedNumberOfItems)
		{
		}

		public void NotifyChangeVolume(float newVolume)
		{
		}

		public void NotifyChangeVolume(float newVolume, Dictionary<string, string> labels)
		{
		}

		public void NotifyChangeCdn(string newCDN)
		{
		}

		public void NotifyChangeCdn(string newCDN, Dictionary<string, string> labels)
		{
		}

		public void SetLoadTimeOffset(long offset)
		{
		}
	}
}
