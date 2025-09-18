namespace Voodoo.Sauce.Internal.Utils
{
	public static class DeviceUtils
	{
		private const string TAG = "DeviceUtils";

		private static string _iosModelMachineName;

		private static string _operatingSystemVersion;

		private static string _manufacturer;

		private static string _model;

		private static string _nativeLocaleCode;

		private const string BuildClassName = "android.os.Build";

		private static readonly string _versionClassName;

		private const string ConnectivityOffline = "Offline";

		private const string ConnectivityNetwork = "Network";

		private const string ConnectivityWifi = "Wifi";

		private const string ConnectivityUnknown = "Unknown";

		private static string _lastConnectivity;

		private static string _installStore;

		public static string OperatingSystemVersion => null;

		public static string Manufacturer => null;

		public static string Model => null;

		public static bool HasBottomSafeArea()
		{
			return false;
		}

		public static bool HasNotch()
		{
			return false;
		}

		public static string GetResolution()
		{
			return null;
		}

		private static T CallDeviceInformationMethod<T>(string className, string method)
		{
			return default(T);
		}

		public static string GetManufacturer()
		{
			return null;
		}

		public static string GetModel()
		{
			return null;
		}

		public static string GetOperatingSystemVersion()
		{
			return null;
		}

		internal static string GetConnectivity()
		{
			return null;
		}

		private static string _getNativeLocaleCode()
		{
			return null;
		}

		internal static string GetAndroidInstallStore()
		{
			return null;
		}

		internal static string GetLocale()
		{
			return null;
		}
	}
}
