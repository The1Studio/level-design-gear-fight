using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Voodoo.Sauce.Core
{
	public interface IRequest
	{
		void Initialize(MonoBehaviour monoBehaviour);

		void Get(string url, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError);

		void Post(string url, Dictionary<string, string> data, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError);

		void PostJson(string url, string jsonData, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError);
	}
}
