using System;
using System.Collections.Generic;
using UnityEngine;

namespace ConsentManagementProviderLib.Android
{
	internal class ConsentWrapperAndroid
	{
		private AndroidJavaObject consentLib;

		private AndroidJavaObject activity;

		private SpClientProxy spClient;

		private AndroidJavaConstruct constructor;

		private CustomConsentClient customConsentClient;

		private static ConsentWrapperAndroid instance;

		public static ConsentWrapperAndroid Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private ConsentWrapperAndroid()
		{
		}

		public void InitializeLib(List<SpCampaign> spCampaigns, int accountId, int propertyId, string propertyName, MESSAGE_LANGUAGE language, CAMPAIGN_ENV campaignsEnvironment, long messageTimeoutMilliSeconds = 3000L, bool? transitionCCPAAuth = null, bool? supportLegacyUSPString = null)
		{
		}

		public void LoadMessage(string authId = null)
		{
		}

		public void LoadPrivacyManager(CAMPAIGN_TYPE campaignType, string pmId, PRIVACY_MANAGER_TAB tab)
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

		internal void Dispose()
		{
		}

		internal void CallShowView(AndroidJavaObject view)
		{
		}

		internal void CallRemoveView(AndroidJavaObject view)
		{
		}

		private void RunOnUiThread(Action action)
		{
		}

		private void InvokeLoadMessage()
		{
		}

		private void InvokeLoadPrivacyManager(string pmId, AndroidJavaObject tab, AndroidJavaObject campaignType, CAMPAIGN_TYPE campaignTypeForLog)
		{
		}

		private void InvokeLoadMessageWithAuthID(string authID)
		{
		}

		public SpConsents GetSpConsents()
		{
			return null;
		}
	}
}
