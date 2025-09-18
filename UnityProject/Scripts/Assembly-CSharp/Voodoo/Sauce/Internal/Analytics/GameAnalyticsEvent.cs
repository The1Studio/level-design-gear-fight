namespace Voodoo.Sauce.Internal.Analytics
{
	internal abstract class GameAnalyticsEvent : BaseAnalyticsEvent
	{
		protected override string GetAnalyticsProviderName()
		{
			return null;
		}

		protected GameAnalyticsEvent(string eventName)
			: base(null)
		{
		}
	}
}
