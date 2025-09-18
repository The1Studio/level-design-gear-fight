namespace com.adjust.sdk
{
	public class AdjustPurchaseVerificationInfo
	{
		public int code { get; set; }

		public string message { get; set; }

		public string verificationStatus { get; set; }

		public AdjustPurchaseVerificationInfo()
		{
		}

		public AdjustPurchaseVerificationInfo(string jsonString)
		{
		}
	}
}
