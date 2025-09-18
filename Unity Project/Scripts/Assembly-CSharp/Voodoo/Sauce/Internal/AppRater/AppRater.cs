using PaperPlaneTools;
using UnityEngine;

namespace Voodoo.Sauce.Internal.AppRater
{
	internal class AppRater : MonoBehaviour
	{
		private static int _minimumGamesPlayed;

		private static bool _isEnabled;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnGamePlayed(int gameCount, bool isHighscore)
		{
		}

		internal static void Initialize(string appstoreAppId, string playstoreAppId, int delayAfterLaunchInSeconds, int postponeCooldownInSeconds, int minimumGamesPlayed)
		{
		}

		internal static void SetCustomAlert(IAlertPlatformAdapter customAlert)
		{
		}

		internal static void TryToShow()
		{
		}

		internal static void ForceShow()
		{
		}
	}
}
