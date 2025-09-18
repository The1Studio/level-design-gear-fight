using Voodoo.Sauce.Ads;
using Voodoo.Sauce.Internal.Ads;

namespace Voodoo.Sauce.Debugger
{
	public class AdsDebugScreen : Screen
	{
		private DebugButtonWithInputField _showInterstitialButton;

		private DebugButtonWithInputField _forceShowInterstitialButton;

		private DebugButtonWithInputField _showRewardedVideoButton;

		private DebugButtonWithInputField _showAppOpenButton;

		private DebugButtonWithInputField _triggerAndShowRewardedVideoButton;

		private DebugButtonWithInputField _showBackupInterstitialButton;

		private DebugButtonWithInputField _showBackupRewardedButton;

		private int _lastTime;

		private TwoAdsInARow _twoAdsInARow;

		private const int TIME_REFRESH_INTERVAL = 5;

		private const string INTERSTITIAL_ADS_CONDITION = "(sec before first FS, sec before session's first FS, sec between FS, games between FS)";

		private const string APP_OPEN_ADS_CONDITION = "(sec in background, sec between AO, sec between FS and AO, sec between RV and AO, sec between AO and FS)";

		private bool _adnTestModeEnabled;

		private bool _adnSdkInitialized;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void Refresh()
		{
		}

		private void ShowAdsInfo()
		{
		}

		private void ShowBannerAdInfo()
		{
		}

		private void ShowInterstitialAdInfo()
		{
		}

		private static string GetInterstitialConditionsInfo()
		{
			return null;
		}

		private void ShowAppOpenAdInfo()
		{
		}

		private static string GetAppOpenConditionsInfo()
		{
			return null;
		}

		private void ShowRewardedVideoAdInfo()
		{
		}

		private void AddDebugUnityPauseWhenDisplayingAds()
		{
		}

		private void ShowRewardedVideoCallbackPopup(bool reward)
		{
		}

		private void ShowMrecAdInfo()
		{
		}

		private void ShowAudioAdInfo()
		{
		}

		private void ShowNativeAdInfo()
		{
		}

		private void ShowBackupInterstitialInfo()
		{
		}

		private void ShowAdnDebugInfo()
		{
		}

		private bool GetAdnTestModeState()
		{
			return false;
		}

		private string GetAdnSdkState()
		{
			return null;
		}

		private static void CopyAdnBidTokenExtraParams()
		{
		}

		private void UpdateAdnTestMode(bool testModeEnabled)
		{
		}

		private static void UpdateButtonState(DebugButtonWithInputField button, AdLoadingState state)
		{
		}

		private static void UpdateButtonState(DebugButtonWithInputField button, bool enable)
		{
		}

		private static string FormatLoadingTime(AdTimer loadingTime)
		{
			return null;
		}

		private static string GetLastDisplayedBackupInterstitial()
		{
			return null;
		}

		private static string GetBackupAdsAssets()
		{
			return null;
		}

		private string GetBackupAdsApiResponse()
		{
			return null;
		}
	}
}
