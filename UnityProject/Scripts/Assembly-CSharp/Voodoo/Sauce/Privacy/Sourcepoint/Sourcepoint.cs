using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ConsentManagementProviderLib;
using Voodoo.Sauce.Core.Model;
using Voodoo.Sauce.Privacy.UI;

namespace Voodoo.Sauce.Privacy.Sourcepoint
{
	public class Sourcepoint : IConsentManagementProvider
	{
		private enum Purpose
		{
			Age = 0,
			StoreAndAccessInformationOnDevice = 1,
			SelectBasicAds = 2,
			CreatePersonalisedAdsProfile = 3,
			SelectPersonalisedAds = 4,
			CreatePersonalisedContentProfile = 5,
			SelectPersonalisedContent = 6,
			MeasureAdsPerformance = 7,
			MeasureContentPerformance = 8,
			ApplyMarketResearchToGenerateAudienceInsights = 9,
			DevelopAndImproveProducts = 10
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public bool waitUserConsent;

			public CmpConsent cmpConsent;

			public Sourcepoint _003C_003E4__this;

			public bool consentUpdated;

			internal void _003CShowPrivacyScreen_003Eb__0(SpConsents spConsents)
			{
			}

			internal void _003CShowPrivacyScreen_003Eb__1()
			{
			}

			internal void _003CShowPrivacyScreen_003Eb__2(Exception exception)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAskConsent_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CmpConsent> _003C_003Et__builder;

			public Sourcepoint _003C_003E4__this;

			private TaskAwaiter<CmpConsent> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowPrivacyScreen_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CmpConsent> _003C_003Et__builder;

			public Sourcepoint _003C_003E4__this;

			public Action openPrivacyScreen;

			private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

			private Action<SpConsents> _003ConConsentReady_003E5__2;

			private Action _003ConConsentUIReady_003E5__3;

			private Action<Exception> _003ConConsentError_003E5__4;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CVoodoo_002DSauce_002DPrivacy_002DIConsentManagementProvider_002DGetConsent_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CmpConsent> _003C_003Et__builder;

			public Sourcepoint _003C_003E4__this;

			public Action<bool> onPrivacyShown;

			private TaskAwaiter<CmpConsent> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CVoodoo_002DSauce_002DPrivacy_002DIConsentManagementProvider_002DOpenPrivacySettings_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CmpConsent> _003C_003Et__builder;

			public Sourcepoint _003C_003E4__this;

			private TaskAwaiter<CmpConsent> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const string TAG = "Sourcepoint";

		private Dictionary<string, Purpose> _keyPurposeDictionary;

		private List<CAMPAIGN_TYPE> _allCampaignTypesToLoad;

		private MESSAGE_LANGUAGE _language;

		private CAMPAIGN_ENV _campaignEnvironment;

		private Action _onConsentUIReady;

		private Action<SpAction> _onConsentAction;

		private Action<Exception> _onConsentError;

		private Action _onConsentUIFinished;

		private Action<SpConsents> _onConsentReady;

		private Action<bool> _onPrivacyShown;

		private SourcepointBehaviour _sourcepointBehaviour;

		private GdprConsent _gdprConsent;

		private Dictionary<Purpose, bool> _purposeConsentDictionary;

		private int _accountId;

		private int _propertyId;

		private int _privacyManagerId;

		private string _propertyName;

		private long _messageTimeoutInSeconds;

		private string _authId;

		private bool _isInitialized;

		public string GetName()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CVoodoo_002DSauce_002DPrivacy_002DIConsentManagementProvider_002DGetConsent_003Ed__23))]
		Task<CmpConsent> IConsentManagementProvider.GetConsent(Action<bool> onPrivacyShown)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CVoodoo_002DSauce_002DPrivacy_002DIConsentManagementProvider_002DOpenPrivacySettings_003Ed__24))]
		Task<CmpConsent> IConsentManagementProvider.OpenPrivacySettings()
		{
			return null;
		}

		void IConsentManagementProvider.ClearCache()
		{
		}

		private void Initialize(Action<bool> onPrivacyShown)
		{
		}

		[AsyncStateMachine(typeof(_003CAskConsent_003Ed__27))]
		private Task<CmpConsent> AskConsent()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CShowPrivacyScreen_003Ed__28))]
		private Task<CmpConsent> ShowPrivacyScreen(Action openPrivacyScreen)
		{
			return null;
		}

		private void SetConfiguration(SourcepointConfiguration configuration)
		{
		}

		private void InstantiateBehaviour()
		{
		}

		private void InitializeCMP()
		{
		}

		private Dictionary<Purpose, bool> GetPurposeConsents(GdprConsent gdprConsent)
		{
			return null;
		}

		private PrivacyConsent GetPrivacyConsent(Dictionary<Purpose, bool> purposeConsentDictionary)
		{
			return null;
		}

		private void TrackConsentUpdate(Dictionary<Purpose, bool> purposeConsentDictionary)
		{
		}

		private void OnConsentUIReadyDebugLog()
		{
		}

		private void OnConsentActionDebugLog(SpAction action)
		{
		}

		private void OnConsentErrorDebugLog(Exception exception)
		{
		}

		private void OnConsentUIFinishedDebugLog()
		{
		}

		private void OnConsentReadyDebugLog(SpConsents consents)
		{
		}
	}
}
