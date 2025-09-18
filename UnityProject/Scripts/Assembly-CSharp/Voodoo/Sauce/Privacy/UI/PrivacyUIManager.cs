using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Events;
using Voodoo.Sauce.Core;

namespace Voodoo.Sauce.Privacy.UI
{
	public class PrivacyUIManager : IPrivacyUIManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPrivacyConsent_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PrivacyConsent> _003C_003Et__builder;

			public PrivacyUIManager _003C_003E4__this;

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

		private const string TAG = "PRIVACY_UI_MANAGER";

		private Dictionary<string, object> _privacyTextDictionary;

		private PrivacyTexts _privacyTexts;

		private Dictionary<string, string> _constTexts;

		private IPrivacyCanvas _privacyCanvas;

		private VoodooSettings _voodooSettings;

		private PrivacyConsent _privacyConsent;

		private bool _isLearnMoreScreenInitialized;

		private bool _isParternScreenInitialized;

		private bool _isDeleteScreenInitialized;

		private bool _isAccessScreenInitialized;

		private PrivacyScreen.Parameters _privacyScreenParameters;

		public void Initialize(IPrivacyUIManagerParameters parameters)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPrivacyConsent_003Ed__13))]
		public Task<PrivacyConsent> GetPrivacyConsent()
		{
			return null;
		}

		private void OpenLearnMoreScreen()
		{
		}

		private void OpenParternScreen()
		{
		}

		private void OpenPolicyPage()
		{
		}

		public void OpenSettingsScreen(bool adsConsent, bool analyticsConsent, bool idfaAuthorizationStatusDeniedOrRestricted, DataScreenInfo dataInfo, UnityAction<PrivacyUpdate> updatePrivacy, UnityAction<string> deleteData, UnityAction<UserDetails> accessData, UnityAction tryOpenDebugger, UnityAction closeSettingsScreen)
		{
		}

		public void CloseSettingsScreen()
		{
		}

		public void OpenCmpSettingsScreen(bool idfaAuthorizationStatusDeniedOrRestricted, DataScreenInfo dataInfo, UnityAction openCmpSettings, UnityAction<string> deleteData, UnityAction<UserDetails> accessData, UnityAction tryOpenDebugger, UnityAction closeCmpSettingsScreen)
		{
		}

		private static string GetOpenCmpSettingsText()
		{
			return null;
		}

		public void CloseCmpSettingsScreen()
		{
		}

		private void OpenDeleteScreen(DataScreenInfo dataInfo, UnityAction<string> deletePrivacy, UnityAction closeAction)
		{
		}

		public void CloseDeleteScreen()
		{
		}

		private void OpenAccessDataScreen(DataScreenInfo dataInfo, UnityAction<UserDetails> sendRequestAction, UnityAction tryOpenDebugger, UnityAction closeAction)
		{
		}

		public void CloseAccessDataScreen()
		{
		}

		private void OpenPopupScreen(string title, string message, string closeButtonText, UnityAction closeCallback)
		{
		}

		public void ClosePopupScreen()
		{
		}

		public void OpenPrivacyNotInitializedPopupScreen(UnityAction closeCallback, VoodooSettings voodooSettings, IPrivacyCanvas privacyCanvas)
		{
		}

		public void OpenUpdatePrivacySuccessPopupScreen(UnityAction closeCallback)
		{
		}

		public void OpenUpdatePrivacyErrorPopupScreen(UnityAction closeCallback)
		{
		}

		public void OpenSuccessPopupScreen(UnityAction closeCallback)
		{
		}

		public void OpenErrorPopupScreen(string errorMessage, UnityAction closeCallback)
		{
		}

		public void OpenConnexionErrorPopupScreen(UnityAction closeCallback)
		{
		}

		public void OpenEmailErrorPopupScreen(UnityAction closeCallback)
		{
		}

		public void OpenLoadingScreen()
		{
		}

		public void CloseLoadingScreen()
		{
		}

		private void UpdateConsent(PrivacyConsent consent)
		{
		}
	}
}
