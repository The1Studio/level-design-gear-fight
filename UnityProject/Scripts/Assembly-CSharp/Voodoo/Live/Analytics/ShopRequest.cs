namespace Voodoo.Live.Analytics
{
	public class ShopRequest : IAnalyticsRequest
	{
		public string EventName { get; }

		private IShopPayload Payload { get; }

		public ShopRequest(string eventName, IShopPayload payload)
		{
		}

		public void Track()
		{
		}
	}
}
