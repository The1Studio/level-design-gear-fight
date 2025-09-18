using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustAttribution
	{
		public string adid { get; set; }

		public string network { get; set; }

		public string adgroup { get; set; }

		public string campaign { get; set; }

		public string creative { get; set; }

		public string clickLabel { get; set; }

		public string trackerName { get; set; }

		public string trackerToken { get; set; }

		public string costType { get; set; }

		public double? costAmount { get; set; }

		public string costCurrency { get; set; }

		public string fbInstallReferrer { get; set; }

		public AdjustAttribution()
		{
		}

		public AdjustAttribution(string jsonString)
		{
		}

		public AdjustAttribution(Dictionary<string, string> dicAttributionData)
		{
		}
	}
}
