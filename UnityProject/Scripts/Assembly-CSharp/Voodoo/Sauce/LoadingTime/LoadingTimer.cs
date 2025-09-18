using System;

namespace Voodoo.Sauce.LoadingTime
{
	internal class LoadingTimer
	{
		private DateTimeOffset _start;

		private DateTimeOffset? _end;

		private DateTimeOffset? _startPause;

		private long _pauseInMilliseconds;

		internal LoadingTimer()
		{
		}

		internal LoadingTimer(DateTimeOffset start)
		{
		}

		internal void Pause()
		{
		}

		internal void Unpause()
		{
		}

		internal void SetEnd(DateTimeOffset end)
		{
		}

		internal long Stop()
		{
			return 0L;
		}

		internal bool IsStopped()
		{
			return false;
		}

		internal long GetStartTimestamp()
		{
			return 0L;
		}

		internal long GetEndTimestamp()
		{
			return 0L;
		}

		internal long GetDuration()
		{
			return 0L;
		}
	}
}
