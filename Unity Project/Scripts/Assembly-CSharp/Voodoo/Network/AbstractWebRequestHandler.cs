using System;
using UnityEngine.Networking;

namespace Voodoo.Network
{
	public abstract class AbstractWebRequestHandler : IWebRequestHandler
	{
		protected Action<UnityWebRequest> _onSuccess;

		protected Action<UnityWebRequest> _onError;

		protected AbstractWebRequestHandler(Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		public virtual void OnSuccess(UnityWebRequest webRequest)
		{
		}

		public virtual void OnError(UnityWebRequest webRequest)
		{
		}
	}
}
