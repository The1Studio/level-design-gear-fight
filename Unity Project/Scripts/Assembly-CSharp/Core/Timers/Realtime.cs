using System;
using UnityEngine;

namespace Core.Timers
{
	internal class Realtime
	{
		public static ITimeSource Source;

		public static DateTime UtcNow => default(DateTime);

		public static bool IsInitialized => false;

		public static void SubscribeOnInitFinishedEvent(Action onInitFinished)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void Initialize()
		{
		}
	}
}
