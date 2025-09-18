using UnityEngine;

namespace Haptics
{
	public class HapticService
	{
		private static IHapticPlayer _hapticPlayer;

		public static bool Enabled { get; set; }

		public static void Play(HapticIntensity intensity)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnLoad()
		{
		}
	}
}
