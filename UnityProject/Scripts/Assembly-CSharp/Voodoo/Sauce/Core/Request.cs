using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Voodoo.Sauce.Core
{
	public class Request : IRequest
	{
		[CompilerGenerated]
		private sealed class _003CdoRequest_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string jsonData;

			public string url;

			public Dictionary<string, string> data;

			public Dictionary<string, string> headers;

			public Action<UnityWebRequest> onSuccess;

			public Action<UnityWebRequest> onError;

			private UnityWebRequest _003Crequest_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CdoRequest_003Ed__5(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private MonoBehaviour _monoBehaviour;

		public void Initialize(MonoBehaviour monoBehaviour)
		{
		}

		public void Get(string url, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		public void Post(string url, Dictionary<string, string> data, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		public void PostJson(string url, string jsonData, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
		}

		[IteratorStateMachine(typeof(_003CdoRequest_003Ed__5))]
		private IEnumerator doRequest(string url, string jsonData, Dictionary<string, string> data, Dictionary<string, string> headers, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onError)
		{
			return null;
		}
	}
}
