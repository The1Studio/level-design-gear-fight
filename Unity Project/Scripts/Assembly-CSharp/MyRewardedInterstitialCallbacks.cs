public class MyRewardedInterstitialCallbacks : RewardedInterstitialCallbacks
{
	private const string TAG = "MyRewardedInterstitialCallbacks";

	public override void AddSoftCurrency(int amount)
	{
	}

	public override void AddHardCurrency(int amount)
	{
	}

	public override int GetSoftCurrency()
	{
		return 0;
	}

	public override int GetHardCurrency()
	{
		return 0;
	}
}
