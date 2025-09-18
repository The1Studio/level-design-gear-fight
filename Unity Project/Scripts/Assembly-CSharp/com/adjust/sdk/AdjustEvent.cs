using System;
using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustEvent
	{
		internal string currency;

		internal string eventToken;

		internal string callbackId;

		internal string transactionId;

		internal string productId;

		internal double? revenue;

		internal List<string> partnerList;

		internal List<string> callbackList;

		internal string receipt;

		internal string receiptBase64;

		internal bool isReceiptSet;

		internal string purchaseToken;

		public AdjustEvent(string eventToken)
		{
		}

		public void setRevenue(double amount, string currency)
		{
		}

		public void addCallbackParameter(string key, string value)
		{
		}

		public void addPartnerParameter(string key, string value)
		{
		}

		public void setCallbackId(string callbackId)
		{
		}

		public void setTransactionId(string transactionId)
		{
		}

		public void setProductId(string productId)
		{
		}

		[Obsolete("This is an obsolete method. Please use separate setter methods for purchase verification parameters.")]
		public void setReceipt(string receipt, string transactionId)
		{
		}

		public void setReceipt(string receipt)
		{
		}

		public void setReceiptBase64(string receiptBase64)
		{
		}

		public void setPurchaseToken(string purchaseToken)
		{
		}
	}
}
