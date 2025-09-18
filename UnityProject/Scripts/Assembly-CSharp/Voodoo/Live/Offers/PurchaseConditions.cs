using System;

namespace Voodoo.Live.Offers
{
	public class PurchaseConditions : ICondition
	{
		private string _lastPurchasedDateKey;

		public int cooldownAfterPurchaseInHours;

		private DateTime _lastPurchaseDate;

		private string _errorMessage;

		public string ErrorMessage => null;

		public bool CanUse()
		{
			return false;
		}

		public bool CanUse(DateTime current)
		{
			return false;
		}

		public void OnFeatureStatusChanged(string status, IFeature feature)
		{
		}

		public void Reset()
		{
		}

		public void LinkToFeature(string id)
		{
		}

		public void SetLastPurchaseDate(DateTime time)
		{
		}
	}
}
