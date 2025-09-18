using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Core.Timers
{
	[Serializable]
	public class Timer : IEquatable<Timer>
	{
		public enum Display
		{
			Short = 0,
			Long = 1
		}

		[Serializable]
		public struct Serialized
		{
			public long EndTime;
		}

		public int Id { get; private set; }

		[field: SerializeField]
		public string Tag { get; private set; }

		public TimeSpan TimeLeft { get; private set; }

		[field: SerializeField]
		public DateTime EndTime { get; private set; }

		public bool IsComplete => false;

		public event Action<Timer> onComplete
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

		public event Action<Timer> onUpdate
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

		public Timer()
		{
		}

		public Timer(DateTime now, TimeSpan duration, string tag, int id)
		{
		}

		public Timer(DateTime endTime, string tag, int id)
		{
		}

		public Timer(Serialized serializedData, string tag, int id)
		{
		}

		public Timer OnComplete(Action<Timer> onComplete)
		{
			return null;
		}

		public void RemoveOnComplete(Action<Timer> onComplete)
		{
		}

		public Timer OnUpdate(Action<Timer> onUpdate)
		{
			return null;
		}

		public void Complete()
		{
		}

		public void Update(DateTime timeNow)
		{
		}

		public bool Equals(Timer other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public Serialized Serialize()
		{
			return default(Serialized);
		}

		public void CheatMoveEndTime(TimeSpan timeSpan)
		{
		}

		public static Timer New(TimeSpan duration, string tag = "")
		{
			return null;
		}

		public static Timer New(int durationInSecond, string tag = "")
		{
			return null;
		}

		public static bool TryGet(string tag, out Timer timer)
		{
			timer = null;
			return false;
		}
	}
}
