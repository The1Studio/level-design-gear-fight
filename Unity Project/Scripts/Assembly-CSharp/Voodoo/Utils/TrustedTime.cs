using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Voodoo.Utils
{
	public class TrustedTime : MonoBehaviour
	{
		private static readonly DateTime UnixEpoch;

		private readonly string ServerEndpoint;

		private static readonly float ServerRefreshInSec;

		private static float _localSecs;

		private static long _epochSecs;

		[PublicAPI]
		public static bool Trusted { get; private set; }

		[PublicAPI]
		public static bool DebugUsed { get; private set; }

		[PublicAPI]
		public static long Timestamp => 0L;

		[PublicAPI]
		public static long TimestampFromNow(long secs)
		{
			return 0L;
		}

		[PublicAPI]
		public static long TimestampFromNow(TimeSpan span)
		{
			return 0L;
		}

		[PublicAPI]
		public static string ToString(long timestamp, string format)
		{
			return null;
		}

		[PublicAPI]
		public static string GetRemainingTimeFormatted(long futureTime, string format = "HH\\:mm\\:ss")
		{
			return null;
		}

		[PublicAPI]
		public static bool IsExpired(long futureTimestamp)
		{
			return false;
		}

		private void Awake()
		{
		}

		private static void ResetTime()
		{
		}

		private void Update()
		{
		}

		public static void DEBUG_addTime(TimeSpan ts)
		{
		}

		public static void DEBUG_addHours(int hours)
		{
		}

		public static void DEBUG_resetTime()
		{
		}
	}
}
