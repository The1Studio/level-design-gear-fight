using UnityEngine;

namespace ConsentManagementProviderLib.Android
{
	internal class AndroidJavaConstruct
	{
		private static readonly string androidPluginName;

		private AndroidJavaClass pluginFactoryClass;

		internal static AndroidJavaObject GetActivity()
		{
			return null;
		}

		internal AndroidJavaObject ConstructLib(AndroidJavaObject spConfig, AndroidJavaObject activity, SpClientProxy spClient)
		{
			return null;
		}

		internal AndroidJavaObject ConstructPrivacyManagerTab(PRIVACY_MANAGER_TAB tab)
		{
			return null;
		}

		internal AndroidJavaObject ConstructCampaign(AndroidJavaObject campaignType, AndroidJavaObject targetingParams, CAMPAIGN_TYPE campaignTypeForLog)
		{
			return null;
		}

		internal AndroidJavaObject ConstructCampaign(AndroidJavaObject campaignType, AndroidJavaObject targetingParams, CAMPAIGN_TYPE campaignTypeForLog, bool? transitionCCPAAuth = null, bool? supportLegacyUSPString = null)
		{
			return null;
		}

		internal AndroidJavaObject ConstructCampaignType(CAMPAIGN_TYPE campaignType)
		{
			return null;
		}

		internal AndroidJavaObject ConstructMessageLanguage(MESSAGE_LANGUAGE lang)
		{
			return null;
		}

		internal AndroidJavaObject ConstructSpConfig(int accountId, int propertyId, string propertyName, long messageTimeout, AndroidJavaObject language, CAMPAIGN_ENV campaignsEnvironment, AndroidJavaObject[] spCampaigns)
		{
			return null;
		}

		internal AndroidJavaObject ConstructTargetingParam(string key, string value)
		{
			return null;
		}

		private AndroidJavaObject ConstructCampaignEnv(CAMPAIGN_ENV environment)
		{
			return null;
		}

		internal void Dispose()
		{
		}
	}
}
