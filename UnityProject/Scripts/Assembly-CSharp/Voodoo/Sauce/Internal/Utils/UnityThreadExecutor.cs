using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Voodoo.Sauce.Internal.Utils
{
	public class UnityThreadExecutor : MonoBehaviour
	{
		private const string TAG = "UnityThreadExecutor";

		private static UnityThreadExecutor _instance;

		private static Thread _mainThreadID;

		private static readonly List<Action> _eventsQueue;

		private static bool _eventsQueueEmpty;

		public static bool IsMainThread => false;

		public static void Initialize()
		{
		}

		public void Awake()
		{
		}

		public static void SafeExecute(Action action)
		{
		}

		public static void Execute(Action action)
		{
		}

		public static void ExecuteInUpdate(Action action)
		{
		}

		public void Update()
		{
		}

		public void OnDisable()
		{
		}
	}
}
