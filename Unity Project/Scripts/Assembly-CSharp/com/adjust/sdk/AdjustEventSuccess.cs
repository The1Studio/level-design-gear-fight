using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustEventSuccess
	{
		public string Adid { get; set; }

		public string Message { get; set; }

		public string Timestamp { get; set; }

		public string EventToken { get; set; }

		public string CallbackId { get; set; }

		public Dictionary<string, object> JsonResponse { get; set; }

		public AdjustEventSuccess()
		{
		}

		public AdjustEventSuccess(Dictionary<string, string> eventSuccessDataMap)
		{
		}

		public AdjustEventSuccess(string jsonString)
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
