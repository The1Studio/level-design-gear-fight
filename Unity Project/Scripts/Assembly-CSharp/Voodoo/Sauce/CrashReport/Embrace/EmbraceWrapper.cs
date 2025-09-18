using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.CrashReport.Embrace
{
	public static class EmbraceWrapper
	{
		private const string TAG = "EmbraceWrapper";

		private const int EMBRACE_PERSONA_MAX_LENGTH = 32;

		internal static bool useRemoteConfig;

		private static bool _isEnabled;

		private static bool _isStarted;

		private static readonly EmbraceStoredValues StoredValues;

		internal static void AnalyticsConsentEvent(bool consent)
		{
		}

		private static void Start()
		{
		}

		internal static void SetUserId(string userId)
		{
		}

		private static void SetUserAsPayer()
		{
		}

		internal static void SetCustomData(string key, string value)
		{
		}

		internal static void SetPersona(string persona)
		{
		}

		internal static void Log(string message)
		{
		}

		internal static void LogInfo(string message, Dictionary<string, string> parameters)
		{
		}

		internal static void LogException(Exception exception)
		{
		}

		private static void ApplyStoredValues()
		{
		}

		private static string FormatPersonaString(string persona)
		{
			return null;
		}
	}
}
