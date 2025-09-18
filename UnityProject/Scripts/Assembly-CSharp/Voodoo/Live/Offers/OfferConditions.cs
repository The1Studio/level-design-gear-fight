using System;
using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class OfferConditions
	{
		public int capping { get; set; }

		public int frequency { get; set; }

		public int cooldownAfterPurchaseInHours { get; set; }

		public DateTime startDate { get; set; }

		public DateTime endDate { get; set; }

		public ActiveTimeConfig activeTime { get; set; }

		public List<DayOfWeek> day { get; set; }

		public string[] tags { get; set; }

		public void ToConditions(Feature feature)
		{
		}
	}
}
