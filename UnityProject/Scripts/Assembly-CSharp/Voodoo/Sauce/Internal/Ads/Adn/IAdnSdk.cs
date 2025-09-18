using System;

namespace Voodoo.Sauce.Internal.Ads.Adn
{
	public interface IAdnSdk
	{
		void SubscribeOnSdkInitializedEvent(Action sdkInitializedEvent);

		bool IsSdkInitialized();

		void SetBidTokenExtraParams(string extraParamsJson);

		string LogBidTokenExtraParams();

		void SetTestMode(bool enabled);
	}
}
