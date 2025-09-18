using System;

namespace Core.Timers
{
	internal class CheatTimeSource : ITimeSource
	{
		public readonly ITimeSource _source;

		private TimeSpan _offset;

		public DateTime UtcNow => default(DateTime);

		public bool IsInitialized => false;

		public CheatTimeSource(ITimeSource source)
		{
		}

		public void SubscribeOnInitFinishedEventInternal(Action onInitFinished)
		{
		}

		public void FastForward(TimeSpan timeSpan)
		{
		}

		public void Reset()
		{
		}
	}
}
