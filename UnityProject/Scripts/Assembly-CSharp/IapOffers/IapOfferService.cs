using System;
using Items;
using UnityEngine;

namespace IapOffers
{
	public class IapOfferService
	{
		private static TimeSpan _claimDuration => default(TimeSpan);

		public static int GetOfferCount(OfferType offerType)
		{
			return 0;
		}

		public static int GetClaimCount(OfferType offerType)
		{
			return 0;
		}

		public static bool IsPurchased(OfferType offerType)
		{
			return false;
		}

		public static void Purchase(OfferType offerType)
		{
		}

		public static bool IsEnabled(OfferCategoryType category)
		{
			return false;
		}

		public static void Claim(OfferType offerType, Transform buttonTransform)
		{
		}

		private static int GetUnclaimedDaysRemaining(OfferType offerType)
		{
			return 0;
		}

		private static int GetPreviousClaimDayDelay(OfferType offerType)
		{
			return 0;
		}

		public static string GetProductKey(OfferType offerType)
		{
			return null;
		}

		public static bool CanClaim(OfferType offerType)
		{
			return false;
		}

		public static TimeSpan GetRemainingClaimTime(OfferType offerType, int claimCount)
		{
			return default(TimeSpan);
		}

		public static bool ClaimCompleted(OfferCategoryType category)
		{
			return false;
		}

		private static DateTime? GetPurchaseDate(OfferType offerType)
		{
			return null;
		}

		private static bool ClaimCompleted(OfferType offerType)
		{
			return false;
		}
	}
}
