using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Firebase
{
	public static class FirebaseInitializer
	{
		private enum InitState
		{
			NONE = 0,
			INITIALIZING = 1,
			SUCCESS = 2,
			FAIL = 3
		}

		private const string TAG = "FirebaseInitializer";

		private static InitState _initState;

		private static readonly List<Action<bool>> _Callbacks;

		public static void Start()
		{
		}

		public static void Subscribe(Action<bool> callback)
		{
		}

		private static void OnInitComplete()
		{
		}
	}
}
