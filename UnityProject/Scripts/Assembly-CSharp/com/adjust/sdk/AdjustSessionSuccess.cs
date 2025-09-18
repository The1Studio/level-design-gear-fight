using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustSessionSuccess
	{
		public string Adid { get; set; }

		public string Message { get; set; }

		public string Timestamp { get; set; }

		public Dictionary<string, object> JsonResponse { get; set; }

		public AdjustSessionSuccess()
		{
		}

		public AdjustSessionSuccess(Dictionary<string, string> sessionSuccessDataMap)
		{
		}

		public AdjustSessionSuccess(string jsonString)
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
