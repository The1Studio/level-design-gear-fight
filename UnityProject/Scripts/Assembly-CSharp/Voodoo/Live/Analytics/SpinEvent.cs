using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class SpinEvent : IAnalyticsRequest
	{
		private const string OFFER_ID = "offer_id";

		public string EventName { get; set; }

		public string Offer_Id { get; }

		public SpinEvent(string eventName, string offerId)
		{
		}

		public void Track()
		{
		}

		protected virtual void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
