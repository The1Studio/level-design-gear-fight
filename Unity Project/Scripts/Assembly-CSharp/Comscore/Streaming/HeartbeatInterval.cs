using System.Collections.Generic;

namespace Comscore.Streaming
{
	public readonly struct HeartbeatInterval
	{
		public long PlayingTime { get; }

		public long Interval { get; }

		public HeartbeatInterval(long playingTime, long interval)
		{
			PlayingTime = 0L;
			Interval = 0L;
		}

		internal Dictionary<string, long> ToHeartbeatIntervalDictionary()
		{
			return null;
		}
	}
}
