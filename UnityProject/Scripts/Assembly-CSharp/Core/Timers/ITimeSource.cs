using System;

namespace Core.Timers
{
	internal interface ITimeSource
	{
		DateTime UtcNow { get; }

		bool IsInitialized { get; }

		void SubscribeOnInitFinishedEventInternal(Action onInitFinished);
	}
}
