using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class AnalyticsEventTimer
	{
		private enum TimerStatus
		{
			Started = 0,
			Stopped = 1,
			Paused = 2
		}

		private DateTime? _startTime;

		private DateTime? _pauseTime;

		private TimeSpan _pauseDuration;

		private TimeSpan _duration;

		private bool? _pauseStatus;

		private TimerStatus? _timerStatus;

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public int GetDuration()
		{
			return 0;
		}

		private TimeSpan GetDurationTimeSpan()
		{
			return default(TimeSpan);
		}
	}
}
