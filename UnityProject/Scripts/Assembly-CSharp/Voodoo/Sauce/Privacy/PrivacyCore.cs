using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Voodoo.Sauce.Core;
using Voodoo.Sauce.Internal.IntegrationCheck;
using Voodoo.Sauce.Privacy.UI;

namespace Voodoo.Sauce.Privacy
{
	internal class PrivacyCore : IModule
	{
		public class GdprConsent
		{
			public bool IsGdprApplicable;

			public bool ExplicitConsentGivenForAds;

			public bool ExplicitConsentGivenForAnalytics;

			public bool IsEmbargoedCountry;

			public bool IsAdsEnforcement;

			public bool IsAdjustEnforcement;

			public bool IsVANEnforcement;

			public string CountryCode;

			public bool IsEEA => false;

			public override string ToString()
			{
				return null;
			}
		}

		public class PrivacyManagerParameters
		{
			public PrivacyConfiguration privacyConfiguration;

			public VoodooSettings voodooSettings;

			public Action<GdprConsent> onConsentGiven;

			public Action<GdprConsent> onConsentUpdate;

			public Action<bool> onPrivacyShown;

			public Action onInternetAvailable;

			public Action onGameStarted;

			public Action onGameFinished;

			public Func<bool> hasGameStarted;

			public Action tryOpenDebugger;

			public Action onDeleteDataRequest;

			public IPrivacyCanvas canvas;

			public IRequest request;

			public IPrivacyAPI privacyAPI;

			public IPrivacyUIManager privacyUIManager;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInstantiate_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

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

		public const string LIMITED_AD_TRACKING_ID = "00000000-0000-0000-0000-000000000000";

		protected string _idfa;

		protected bool _adTrackingEnabled;

		protected bool _adsConsent;

		protected bool _analyticsConsent;

		protected bool _isGdprApplicable;

		protected bool _isCcpaApplicable;

		protected GdprConsent _gdprConsent;

		protected string _vendorId;

		protected IdfaAuthorizationStatus _idfaAuthorizationStatus;

		[AsyncStateMachine(typeof(_003CInstantiate_003Ed__12))]
		public virtual Task Instantiate(VoodooSettings voodooSettings)
		{
			return null;
		}

		public virtual List<IntegrationCheckMessage> IntegrationCheck(VoodooSettings settings)
		{
			return null;
		}

		public virtual void Initialize(PrivacyManagerParameters p)
		{
		}

		public virtual bool HasLimitAdTrackingEnabled()
		{
			return false;
		}

		public virtual string GetAdvertisingId(bool forceZerosForLimitedAdTracking = true)
		{
			return null;
		}

		public virtual string GetVendorId()
		{
			return null;
		}

		public virtual bool HasAdsConsent()
		{
			return false;
		}

		public virtual bool HasAnalyticsConsent()
		{
			return false;
		}

		public virtual bool IsGdprApplicable()
		{
			return false;
		}

		public virtual bool IsAdsEnforcementEnabled()
		{
			return false;
		}

		public virtual bool IsAdjustEnforcementEnabled()
		{
			return false;
		}

		public virtual bool IsCcpaApplicable()
		{
			return false;
		}

		public virtual bool UserRequestedToBeForgotten()
		{
			return false;
		}

		internal virtual void OpenPrivacySettings(Action onSettingsClosed = null)
		{
		}

		internal virtual void ShowPrivacyAuthorization()
		{
		}

		public virtual IdfaAuthorizationStatus GetAuthorizationStatus()
		{
			return default(IdfaAuthorizationStatus);
		}

		internal virtual string GetCmpName()
		{
			return null;
		}

		internal virtual void ClearCMPCache()
		{
		}
	}
}
