using System;
using System.Collections.Generic;
using UnityEngine;

namespace ConsentManagementProviderLib
{
	public static class CMP
	{
		private static GameObject mainThreadBroadcastEventsExecutor;

		public static bool useGDPR;

		public static bool useCCPA;

		public static bool useUSNAT;

		private static bool IsEditor => false;

		public static void Initialize(List<SpCampaign> spCampaigns, int accountId, int propertyId, string propertyName, MESSAGE_LANGUAGE language, string gdprPmId, string ccpaPmId, string usnatPmId, CAMPAIGN_ENV campaignsEnvironment, long messageTimeoutInSeconds = 3L, bool? transitionCCPAAuth = null, bool? supportLegacyUSPString = null)
		{
		}

		public static void LoadMessage(string authId = null)
		{
		}

		public static void ClearAllData(string authId = null)
		{
		}

		public static void LoadPrivacyManager(CAMPAIGN_TYPE campaignType, string pmId, PRIVACY_MANAGER_TAB tab)
		{
		}

		public static void CustomConsentGDPR(string[] vendors, string[] categories, string[] legIntCategories, Action<GdprConsent> onSuccessDelegate)
		{
		}

		public static void DeleteCustomConsentGDPR(string[] vendors, string[] categories, string[] legIntCategories, Action<GdprConsent> onSuccessDelegate)
		{
		}

		public static SpConsents GetSpConsents()
		{
			return null;
		}

		public static GdprConsent GetCustomConsent()
		{
			return null;
		}

		public static void Dispose()
		{
		}

		private static void CreateBroadcastExecutorGO()
		{
		}

		private static void RemoveIos14SpCampaign(ref List<SpCampaign> spCampaigns)
		{
		}

		private static bool IsSpCampaignsValid(List<SpCampaign> spCampaigns)
		{
			return false;
		}
	}
}
