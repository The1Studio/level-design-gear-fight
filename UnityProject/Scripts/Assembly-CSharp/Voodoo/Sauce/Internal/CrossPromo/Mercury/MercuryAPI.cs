using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using Voodoo.Sauce.Internal.CrossPromo.Mercury.Models;
using Voodoo.Sauce.Internal.CrossPromo.Mercury.Parameters;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury
{
	public class MercuryAPI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CGetGameInfoCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GetGameInfoParameters parameters;

			public Action<MercuryRequestInfo> onFailure;

			public Action<MercuryRequestInfo> onSuccess;

			private UnityWebRequest _003CwebRequest_003E5__2;

			private float _003CstartTime_003E5__3;

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
			public _003CGetGameInfoCoroutine_003Ed__9(int _003C_003E1__state)
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

		private const string TAG = "MercuryAPI";

		private static MercuryAPI _instance;

		private const string MERCURY_URL = "https://crosspromo.voodoo.io";

		private const string MERCURY_TOKEN = "Token 16aaae9ea829470dc2993d0afe865d1165230589";

		private static PrivacyCore _privacy => null;

		public static MercuryAPI Instance => null;

		public static void GetGameInfo(GetGameInfoParameters parameters, Action<MercuryRequestInfo> onSuccess, Action<MercuryRequestInfo> onFailure)
		{
		}

		[IteratorStateMachine(typeof(_003CGetGameInfoCoroutine_003Ed__9))]
		private static IEnumerator GetGameInfoCoroutine(GetGameInfoParameters parameters, Action<MercuryRequestInfo> onSuccess, Action<MercuryRequestInfo> onFailure)
		{
			return null;
		}

		public static UnityWebRequest CreateGameInfoRequest(GetGameInfoParameters info)
		{
			return null;
		}

		public static GetGameInfoParameters CreateDefaultGameInfoParameters(string format, string gameList, string waterfallId, bool restrictedPrivacy)
		{
			return default(GetGameInfoParameters);
		}
	}
}
