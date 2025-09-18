using System.Collections.Generic;
using UnityEngine;

public class PlayOnSDK
{
	public enum LogLevel
	{
		None = 0,
		Info = 1,
		Debug = 2
	}

	public enum Position
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		CenterLeft = 3,
		Centered = 4,
		CenterRight = 5,
		BottomLeft = 6,
		BottomCenter = 7,
		BottomRight = 8
	}

	public enum AdUnitType
	{
		AudioBannerAd = 0,
		AudioRewardedBannerAd = 1,
		AudioLogoAd = 2,
		AudioRewardedLogoAd = 3
	}

	public enum AdUnitRewardType
	{
		InLevel = 0,
		EndLevel = 1
	}

	public enum AdUnitActionButtonType
	{
		Mute = 0,
		Close = 1,
		None = 2
	}

	public enum ConsentType
	{
		Undefined = 0,
		None = 1,
		Gdpr = 2,
		Ccpa = 3
	}

	public enum AdSizingMethod
	{
		Flexible = 0,
		Strict = 1
	}

	public delegate void PlayOnNoArgsDelegate();

	public delegate void PlayOnStateDelegate(bool flag);

	public delegate void PlayOnImpressionDelegate(AdUnit.ImpressionData data);

	public delegate void PlayOnFloatDelegate(float amount);

	public delegate void PlayOnErrorDelegate(int errorParam, string error);

	public class PlayOnListener : AndroidJavaProxy
	{
		public PlayOnNoArgsDelegate OnInitializationFinished;

		public PlayOnErrorDelegate OnInitializationFailed;

		public PlayOnListener()
			: base((string)null)
		{
		}

		private void onInitializationFinished()
		{
		}

		private void onInitializationFailed(int errorParam, string error)
		{
		}
	}

	public delegate void OnApplicationPause(bool isPaused);

	public const string BundleClassName = "android.os.Bundle";

	public const string DateClassName = "java.util.Date";

	public const string HashClassName = "java.util.HashMap";

	private static AndroidJavaObject _androidBridge;

	private static readonly string AndroidBridge;

	public static string SDK_VERSION;

	private static PlayOnListener playOnListener;

	public static OnApplicationPause onApplicationPause;

	public static PlayOnNoArgsDelegate OnInitializationFinished
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static PlayOnErrorDelegate OnInitializationFailed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static AndroidJavaObject getBridge()
	{
		return null;
	}

	public static void Initialize(string apiKey, string iosStoreId = "")
	{
	}

	public static bool IsInitialized()
	{
		return false;
	}

	public static void SetIsChildDirected(bool flag)
	{
	}

	public static float GetDeviceVolumeLevel()
	{
		return 0f;
	}

	public static string GetConsentString()
	{
		return null;
	}

	public static bool IsGeneralConsentGiven()
	{
		return false;
	}

	public static void ClearConsentString()
	{
	}

	public static void SetConsentString(string consentString)
	{
	}

	public static void SetGdprConsent(bool consent)
	{
	}

	public static void SetGdprConsent(bool consent, string consentString)
	{
	}

	public static void SetDoNotSell(bool isApplied)
	{
	}

	public static void SetDoNotSell(bool isApplied, string consentString)
	{
	}

	public static void ForceRegulationType(ConsentType type)
	{
	}

	public static void ClearForceRegulationType()
	{
	}

	public static ConsentType GetRegulationType()
	{
		return default(ConsentType);
	}

	public static void AddCustomAttribute(string key, string value)
	{
	}

	public static void ClearCustomAttributes()
	{
	}

	public static void RemoveCustomAttribute(string key)
	{
	}

	public static List<SortedDictionary<string, string>> GetCustomAttributes()
	{
		return null;
	}

	public static List<SortedDictionary<string, string>> GetCustomAttributes(string key)
	{
		return null;
	}

	public static void SetLogLevel(LogLevel level)
	{
	}

	public static void LogE(LogLevel type, string message)
	{
	}

	public static void LogW(LogLevel type, string message)
	{
	}

	public static void LogI(LogLevel type, string message)
	{
	}

	public static void RequestTrackingAuthorization()
	{
	}

	public static void SetPlayerID(string id)
	{
	}

	public static string GetPlayerID()
	{
		return null;
	}

	public static int GetOptimalEditorDPI()
	{
		return 0;
	}

	public static void SetOptimalDPI()
	{
	}

	public static void SetUnityEditorDPI(int dpi)
	{
	}

	public static float GetUnityEditorDPI()
	{
		return 0f;
	}

	public static bool DPISettedByUser()
	{
		return false;
	}

	public static float GetDeviceScale()
	{
		return 0f;
	}

	private static void onPause()
	{
	}

	private static void onResume()
	{
	}
}
