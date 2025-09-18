using UnityEngine;

public class AppHarbrAndroid : AndroidAdWatcher
{
	internal class BackgroundCallbackProxy : AndroidJavaProxy
	{
		public BackgroundCallbackProxy()
			: base((string)null)
		{
		}

		public void onEvent(string propsStr)
		{
		}
	}

	private static string AHSDKDEBUG_CLASS_NAME;

	private static string APPHARBR_CONFIGURATION_WRAPPER_CLASS;

	public static void Initialize(AHAdSdk ahAdSdk, AHSdkConfiguration sdkConfiguration)
	{
	}

	private static AndroidJavaObject setupConfigObj(AHSdkConfiguration configuration)
	{
		return null;
	}

	private static AndroidJavaObject GetAhDebugObject(AHSdkConfiguration configuration)
	{
		return null;
	}

	private static AndroidJavaObject getApplicationContext()
	{
		return null;
	}

	public static void LaunchIntegrationDashboard(AHAdSdk mediationSdk)
	{
	}
}
