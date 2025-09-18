using System;

namespace Voodoo.Sauce.Firebase
{
	internal static class FirebaseCrashlyticsWrapper
	{
		private const string TAG = "FirebaseCrashlyticsWrapper";

		private static bool _isFirebaseInitialized;

		private static bool _isEnabled;

		internal static void SubscribeToFirebaseInitialization(bool consent)
		{
		}

		internal static void SetLevelStart(string levelNumber)
		{
		}

		internal static void SetLevelFinish(string levelNumber)
		{
		}

		internal static void SetUserId(string userId)
		{
		}

		internal static void SetCustomData(string key, string value)
		{
		}

		internal static void Log(string message)
		{
		}

		internal static void LogException(Exception exception)
		{
		}

		private static void SetCrashlyticsCollection(bool consent)
		{
		}
	}
}
