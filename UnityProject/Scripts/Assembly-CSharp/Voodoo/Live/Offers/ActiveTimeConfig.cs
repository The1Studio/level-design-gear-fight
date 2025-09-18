using System;

namespace Voodoo.Live.Offers
{
	[Serializable]
	public class ActiveTimeConfig
	{
		public ActiveTimeType type;

		public TimeSpan from;

		public int duration;

		public TimeSpan to;
	}
}
