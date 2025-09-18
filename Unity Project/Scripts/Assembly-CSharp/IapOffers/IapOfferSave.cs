using System;
using Voodoo.Nakama.Data;

namespace IapOffers
{
	[Serializable]
	public class IapOfferSave : ServerBaseData
	{
		public int StandardOfferClaimCount;

		public int PremiumOfferClaimCount;

		public int TroopOfferClaimCount;

		public DateTime? StandardOfferPurchaseDateUtc;

		public DateTime? PremiumOfferPurchaseDateUtc;

		public DateTime? TroopOfferPurchaseDateUtc;
	}
}
