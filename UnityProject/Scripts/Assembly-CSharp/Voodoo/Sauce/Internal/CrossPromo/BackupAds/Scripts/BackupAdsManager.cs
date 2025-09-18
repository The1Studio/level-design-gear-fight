using System;
using System.Collections.Generic;
using Voodoo.Sauce.Internal.Ads;
using Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Canvas;
using Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts.Models;
using Voodoo.Sauce.Internal.CrossPromo.Configuration;
using Voodoo.Sauce.Internal.CrossPromo.Mercury.Models;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.CrossPromo.BackupAds.Scripts
{
	internal class BackupAdsManager
	{
		private enum BackupAdsState
		{
			Unknown = 0,
			Disabled = 1,
			NotInitialized = 2,
			WaitingInternetReachability = 3,
			Playing = 4,
			NoAds = 5
		}

		private static BackupAdsManager _instance;

		private const string TAG = "BackupAdsManager";

		private const string BACKUP_FS_FORMAT = "FS_APPINSTALL";

		private const string K_PREFS_LATEST_WATERFALL_ID = "BackupFS_LatestWaterfallId";

		private const float DELAY_BEFORE_SHOWING_CLOSE_BUTTON_INTERSTITIAL = 5f;

		private const float DELAY_BEFORE_SHOWING_CLOSE_BUTTON_REWARDED = 15f;

		private BackupAdsConfig _currentConfig;

		private bool _wasBannerShown;

		private static bool _initialized;

		private AdLoadingState _wasDownloaded;

		private BackupAdsCanvas _canvasInstance;

		internal List<MercuryPromotedAsset> currentAssets;

		internal MercuryWaterfall mercuryWaterfall;

		internal BackupAdsInfo currentAdInfo;

		internal BackupAdsInfo lastDisplayedAdInfo;

		private Action<bool> _completeCallback;

		private PrivacyCore.GdprConsent _gdprConsent;

		private BackupAdsState _backupAdsState;

		private string LatestWaterfallId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static BackupAdsManager Instance => null;

		internal BackupAdsManager(BackupAdsConfig config)
		{
		}

		public void Initialize(PrivacyCore.GdprConsent gdprConsent)
		{
		}

		private void OnGameInfoReceived(MercuryRequestInfo info)
		{
		}

		private void OnGameInfoError(MercuryRequestInfo info)
		{
		}

		private int WaterfallSort(MercuryPromotedAsset x, MercuryPromotedAsset y)
		{
			return 0;
		}

		internal bool IsRestrictedPrivacy()
		{
			return false;
		}

		internal bool IsEnabled()
		{
			return false;
		}

		internal bool ShouldShowWithoutInternet()
		{
			return false;
		}

		internal AdLoadingState IsBackupAdAvailable()
		{
			return default(AdLoadingState);
		}

		internal void ShowCrossPromoInterstitial(Action<bool> onComplete)
		{
		}

		private BackupAdsInfo GetNextInterstitial()
		{
			return null;
		}

		public bool CanShowBackupInterstitial(bool showLogs = true)
		{
			return false;
		}

		private void OnInterstitialClose()
		{
		}

		private void OnInterstitialComplete(bool reward)
		{
		}

		private void OnInterstitialClicked()
		{
		}

		internal void ShowCrossPromoRewardedVideo(Action<bool> onComplete)
		{
		}

		private BackupAdsInfo GetNextRewardedVideo()
		{
			return null;
		}

		public bool CanShowBackupRewardedVideo(bool showLogs = true)
		{
			return false;
		}

		private void OnRewardedVideoClose()
		{
		}

		private void OnRewardedVideoComplete(bool reward)
		{
		}

		private void OnRewardedVideoClicked()
		{
		}

		private void AddAssetToWaterfall(MercuryPromotedAsset asset)
		{
		}

		private void LoadWaterfallFromCache()
		{
		}

		private BackupAdsInfo GetNextAsset(BackupAdsInfo.BackupAdType adType)
		{
			return null;
		}
	}
}
