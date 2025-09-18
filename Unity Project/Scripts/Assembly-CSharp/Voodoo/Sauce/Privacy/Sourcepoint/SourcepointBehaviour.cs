using System;
using ConsentManagementProviderLib;
using ConsentManagementProviderLib.EventHandlerInterface;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Voodoo.Sauce.Privacy.Sourcepoint
{
	public class SourcepointBehaviour : MonoBehaviour, IOnConsentUIReady, IConsentEventHandler, IEventSystemHandler, IOnConsentAction, IOnConsentError, IOnConsentUIFinished, IOnConsentReady
	{
		public class SourcepointBehaviourParameters
		{
			public Action onConsentUIReady;

			public Action<SpAction> onConsentAction;

			public Action<Exception> onConsentError;

			public Action onConsentUIFinished;

			public Action<SpConsents> onConsentReady;
		}

		private Action _onConsentUIReady;

		private Action<SpAction> _onConsentAction;

		private Action<Exception> _onConsentError;

		private Action _onConsentUIFinished;

		private Action<SpConsents> _onConsentReady;

		public void Initialize(SourcepointBehaviourParameters parameters)
		{
		}

		public void OnConsentUIReady()
		{
		}

		public void OnConsentAction(SpAction action)
		{
		}

		public void OnConsentError(Exception exception)
		{
		}

		public void OnConsentUIFinished()
		{
		}

		public void OnConsentReady(SpConsents consents)
		{
		}
	}
}
