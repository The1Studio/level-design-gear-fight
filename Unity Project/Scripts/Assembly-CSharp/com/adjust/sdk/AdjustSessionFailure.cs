using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustSessionFailure
	{
		public string Adid { get; set; }

		public string Message { get; set; }

		public string Timestamp { get; set; }

		public bool WillRetry { get; set; }

		public Dictionary<string, object> JsonResponse { get; set; }

		public AdjustSessionFailure()
		{
		}

		public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap)
		{
		}

		public AdjustSessionFailure(string jsonString)
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
