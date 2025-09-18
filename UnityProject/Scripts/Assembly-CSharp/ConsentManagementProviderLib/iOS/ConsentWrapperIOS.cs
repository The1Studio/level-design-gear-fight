using System;
using System.Collections.Generic;
using UnityEngine;

namespace ConsentManagementProviderLib.iOS
{
	internal class ConsentWrapperIOS
	{
		private static ConsentWrapperIOS instance;

		private static GameObject IOSListenerGO;

		private static CMPiOSListenerHelper iOSListener;

		public static ConsentWrapperIOS Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private static void CreateHelperIOSListener()
		{
		}

		public void InitializeLib(int accountId, int propertyId, string propertyName, bool gdpr, bool ccpa, bool usnat, MESSAGE_LANGUAGE language, string gdprPmId, string ccpaPmId, string usnatPmId, List<SpCampaign> spCampaigns, CAMPAIGN_ENV campaignsEnvironment, long messageTimeoutInSeconds = 3L, bool? transitionCCPAAuth = null, bool? supportLegacyUSPString = null)
		{
		}

		public void LoadMessage(string authId = null)
		{
		}

		public void LoadGDPRPrivacyManager()
		{
		}

		public void LoadCCPAPrivacyManager()
		{
		}

		public void LoadUSNATPrivacyManager()
		{
		}

		public void CustomConsentGDPR(string[] vendors, string[] categories, string[] legIntCategories, Action<GdprConsent> onSuccessDelegate)
		{
		}

		public void DeleteCustomConsentGDPR(string[] vendors, string[] categories, string[] legIntCategories, Action<GdprConsent> onSuccessDelegate)
		{
		}

		public GdprConsent GetCustomGdprConsent()
		{
			return null;
		}

		public SpConsents GetSpConsents()
		{
			return null;
		}

		public void ClearAllData()
		{
		}

		public void Dispose()
		{
		}
	}
}
