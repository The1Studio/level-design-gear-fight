using System.Collections.Generic;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Debugger
{
	public class AnalyticsProviderDebugScreen : Screen
	{
		private const string DEFAULT_TEST_EVENT_NAME = "test_analytics_provider_";

		private readonly List<AnalyticsProviderButton> _providerUiItemList;

		private List<VoodooSauce.AnalyticsProvider> _providerEnumList;

		private AnalyticsProviderButton _comscoreButton;

		private int _comscoreIndex;

		private void Start()
		{
		}

		private List<VoodooSauce.AnalyticsProvider> GetAllProviderEnum()
		{
			return null;
		}

		private void SetupAnalyticsItem(int index)
		{
		}

		private void SetupComscoreButton()
		{
		}

		private void RefreshComscoreButton()
		{
		}

		private void ProviderTestClicked(int index)
		{
		}

		private static string GetDescMessageOnSending(BaseAnalyticsProviderWithLogger providerWithLogger)
		{
			return null;
		}

		private static string GetTestEventName(int index)
		{
			return null;
		}

		private List<VoodooSauce.AnalyticsProvider> GetProviderList(int index)
		{
			return null;
		}

		private void ReceiveAnalyticsEvent(DebugAnalyticsLog log, bool isUpdateFromExisting)
		{
		}

		private static string GetDescTextFromState(DebugAnalyticsLog log)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
