using UnityEngine;

public class AdUnit
{
	private enum LogoPositionType
	{
		Prefab = 0,
		Rect = 1,
		Direct = 2
	}

	public class ImpressionData
	{
		private string placementID;

		private string sessionID;

		private PlayOnSDK.AdUnitType adType;

		private string country;

		private double revenue;

		public ImpressionData(AndroidJavaObject ptr)
		{
		}

		public string GetPlacementID()
		{
			return null;
		}

		public string GetSessionID()
		{
			return null;
		}

		public PlayOnSDK.AdUnitType GetAdType()
		{
			return default(PlayOnSDK.AdUnitType);
		}

		public string GetCountry()
		{
			return null;
		}

		public double GetRevenue()
		{
			return 0.0;
		}
	}

	public PlayOnSDK.AdUnitType type;

	public float rewardValue;

	public PlayOnSDK.AdUnitRewardType rewardType;

	protected AndroidJavaObject client;

	public const int AD_SIZE_LIMIT_DP_MIN = 70;

	public const int AD_SIZE_LIMIT_DP_MAX = 120;

	private float fadeValue;

	private float sceneVolumeValue;

	private LogoPositionType posType;

	private AdListener adListener;

	private RectTransform linkedRect;

	private Canvas linkedCanvas;

	private PlayOnSDK.Position linkedPosition;

	private PlayOnSDK.AdSizingMethod sizingMethod;

	private AdUnitAnchor adUnitAnchor;

	public AdListener AdCallbacks => null;

	public AdUnit(PlayOnSDK.AdUnitType adType)
	{
	}

	protected void SetAdListener()
	{
	}

	public void ShowAd()
	{
	}

	public void CloseAd()
	{
	}

	public void SetBanner(PlayOnSDK.Position location)
	{
	}

	public bool IsAdAvailable()
	{
		return false;
	}

	public void SetReward(PlayOnSDK.AdUnitRewardType rewardType, float value)
	{
	}

	public void SetPopup(PlayOnSDK.Position position, int xOffset, int yOffset)
	{
	}

	public void SetProgressBar(Color progressBarColor)
	{
	}

	public void SetActionButton(PlayOnSDK.AdUnitActionButtonType actionType, float delayTime)
	{
	}

	public void LinkLogoToRectTransform(PlayOnSDK.Position position, RectTransform rectTransform, Canvas canvas, PlayOnSDK.AdSizingMethod sizingMethod = PlayOnSDK.AdSizingMethod.Flexible)
	{
	}

	public void LinkLogoToPrefab(AdUnitAnchor adUnitAnchor)
	{
	}

	public void SetLogo(PlayOnSDK.Position position, int xOffset, int yOffset, int size)
	{
	}

	private void UpdateLogoPosition(PlayOnSDK.Position position, int xOffset, int yOffset, int size)
	{
	}

	public void SetVisualization(Color tint, Color background)
	{
	}

	public void TrackRewardedOffer()
	{
	}

	private void onShow()
	{
	}

	private void onClose()
	{
	}

	public void Dispose()
	{
	}
}
