using System;
using UnityEngine.Networking;

namespace Voodoo.Network
{
	public class WebRequestHandler : AbstractWebRequestHandler
	{
		public WebRequestHandler(Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
			: base(null, null)
		{
		}
	}
}
