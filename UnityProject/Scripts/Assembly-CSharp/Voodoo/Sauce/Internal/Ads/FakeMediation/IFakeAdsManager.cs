namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	public interface IFakeAdsManager
	{
		void Initialize();

		bool IsEnabled();

		void SetEnabled(bool isEnabled);
	}
}
