using UnityEngine;

public abstract class RewardedInterstitialCallbacks : MonoBehaviour
{
	public abstract void AddSoftCurrency(int amount);

	public abstract void AddHardCurrency(int amount);

	public abstract int GetSoftCurrency();

	public abstract int GetHardCurrency();
}
