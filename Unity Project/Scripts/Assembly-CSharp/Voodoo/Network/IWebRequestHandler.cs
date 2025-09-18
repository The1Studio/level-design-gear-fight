using UnityEngine.Networking;

namespace Voodoo.Network
{
	public interface IWebRequestHandler
	{
		void OnSuccess(UnityWebRequest webRequest);

		void OnError(UnityWebRequest webRequest);
	}
}
