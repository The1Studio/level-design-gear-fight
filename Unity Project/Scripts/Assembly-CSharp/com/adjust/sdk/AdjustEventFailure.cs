using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustEventFailure
	{
		public string Adid { get; set; }

		public string Message { get; set; }

		public string Timestamp { get; set; }

		public string EventToken { get; set; }

		public string CallbackId { get; set; }

		public bool WillRetry { get; set; }

		public Dictionary<string, object> JsonResponse { get; set; }

		public AdjustEventFailure()
		{
		}

		public AdjustEventFailure(Dictionary<string, string> eventFailureDataMap)
		{
		}

		public AdjustEventFailure(string jsonString)
		{
		}

		public void BuildJsonResponseFromString(string jsonResponseString)
		{
		}

		public string GetJsonResponse()
		{
			return null;
		}
	}
}
