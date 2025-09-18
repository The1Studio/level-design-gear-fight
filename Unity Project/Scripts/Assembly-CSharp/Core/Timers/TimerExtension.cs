using System;

namespace Core.Timers
{
	public static class TimerExtension
	{
		private static readonly string[] SHORT_SUFFIX;

		private static readonly string[] LONG_SUFFIX;

		public static string Format(this TimeSpan span, bool forceFullString = false)
		{
			return null;
		}

		public static string Format(this Timer timer, bool forceFullString = false)
		{
			return null;
		}

		private static string GetConciseDisplayString(TimeSpan span, Timer.Display display, int maxUnitsToShow, float sizer)
		{
			return null;
		}

		public static string Format(this TimeSpan span, Timer.Display display, int maxUnitsToShow = 4, float sizer = 100f)
		{
			return null;
		}

		public static string Format(this Timer timer, Timer.Display display, int maxUnitsToShow = 4, float sizer = 100f)
		{
			return null;
		}
	}
}
