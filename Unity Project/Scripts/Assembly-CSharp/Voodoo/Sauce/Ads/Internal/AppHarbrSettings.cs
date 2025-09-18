using UnityEngine;

namespace Voodoo.Sauce.Ads.Internal
{
	public class AppHarbrSettings : ScriptableObject
	{
		[Header("Debugging")]
		[Tooltip("Enable this to see debug logs from AppHarbr.")]
		public bool debugMode;

		[Tooltip("Enable this to block all ads.")]
		public bool alwaysBlock;

		[Tooltip("Enable this to report all ads.")]
		public bool alwaysReport;

		[Header("Default Keys")]
		public string iosAppKey;

		public string androidAppKey;
	}
}
