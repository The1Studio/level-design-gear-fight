namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	internal abstract class BaseAnalyticsProviderWithLogger : IAnalyticsProvider
	{
		public bool IsInitialized { get; protected set; }

		internal abstract VoodooSauce.AnalyticsProvider GetProviderEnum();

		public abstract void Instantiate(string mediation);

		public abstract void Initialize(AnalyticsProviderInfo info);

		internal virtual string GetUninitializedErrorMessage()
		{
			return null;
		}
	}
}
