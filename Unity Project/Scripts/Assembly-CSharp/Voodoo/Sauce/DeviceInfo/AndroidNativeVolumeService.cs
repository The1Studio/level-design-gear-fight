using UnityEngine;

namespace Voodoo.Sauce.DeviceInfo
{
	public static class AndroidNativeVolumeService
	{
		private const string TAG = "AndroidNativeVolumeService";

		private static int _streamMusic;

		private static int? _maxVolume;

		private static AndroidJavaObject _audioManager;

		private static bool _audioManagerHasError;

		private static bool _maxVolumeHasError;

		private static AndroidJavaObject DeviceAudio => null;

		public static int GetSystemVolume()
		{
			return 0;
		}

		public static int RetryGetSystemVolume()
		{
			return 0;
		}
	}
}
