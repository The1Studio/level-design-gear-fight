using System;
using System.Collections.Generic;
using UnityEngine;

namespace AppHarbrSDK.Internal
{
	public class MainThreadDispatcher : MonoBehaviour
	{
		private static MainThreadDispatcher instance;

		private static List<Action> adEventsQueue;

		private static bool adEventsQueueEmpty;

		private void Update()
		{
		}

		public static void InitializeIfNeeded()
		{
		}

		public static void InvokeOnMainThread(Action action)
		{
		}
	}
}
