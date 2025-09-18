namespace Voodoo.Sauce.Internal.Ads
{
	internal class AudioAdsGracePeriod
	{
		private const string FIRST_GRACE_PERIOD_ENDED = "FirstGracePeriodEnded";

		private const string FIRST_GRACE_PERIOD_TOTAL_TIME = "FirstGracePeriodTotalTime";

		private readonly IAudioAdsTime _time;

		private int _gameStartTimeStamp;

		private int _gameDuration;

		public int FirstAudioAdGracePeriod { get; }

		public int NextAudioAdGracePeriod { get; }

		public bool GracePeriodEnded { get; private set; }

		public AudioAdState State => default(AudioAdState);

		public int SessionTotalElapsedTime { get; private set; }

		public AudioAdsGracePeriod(int firstAudioAdGracePeriod, int nextAudioAdGracePeriod, IAudioAdsTime time = null)
		{
		}

		public void StartTimer()
		{
		}

		public void UpdateTimer()
		{
		}

		private void Resolve()
		{
		}

		private void ResolveFirstAudioAd()
		{
		}

		private void ResolveNextAudioAd()
		{
		}

		public static void ForceReset()
		{
		}

		public static int GetFirstGracePeriodTotalTime()
		{
			return 0;
		}

		public static bool IsFirstGracePeriodEnded()
		{
			return false;
		}

		private static void EndFirstGracePeriod()
		{
		}
	}
}
