using UnityEngine;

public class AdListener : AndroidJavaProxy
{
	public PlayOnSDK.PlayOnStateDelegate OnAvailabilityChanged;

	public PlayOnSDK.PlayOnNoArgsDelegate OnShow;

	public PlayOnSDK.PlayOnNoArgsDelegate OnClose;

	public PlayOnSDK.PlayOnNoArgsDelegate OnClick;

	public PlayOnSDK.PlayOnFloatDelegate OnReward;

	public PlayOnSDK.PlayOnNoArgsDelegate OnUserClose;

	public PlayOnSDK.PlayOnImpressionDelegate OnImpression;

	public PlayOnSDK.PlayOnNoArgsDelegate OnAdBlocked;

	public bool adBlocked;

	public AdListener()
		: base((string)null)
	{
	}

	private void onAvailabilityChanged(bool availablity)
	{
	}

	private void onShow()
	{
	}

	private void onClose()
	{
	}

	private void onClick()
	{
	}

	private void onReward(float amount)
	{
	}

	private void onUserClose()
	{
	}

	private void onImpression(AndroidJavaObject data)
	{
	}
}
