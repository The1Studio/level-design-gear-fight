using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;
using Voodoo.Sauce.Internal.CrossPromo.Mercury.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury
{
	public static class MercuryDownloader
	{
		[CompilerGenerated]
		private sealed class _003CDownloadVideoCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MercuryPromotedAsset asset;

			public Action<MercuryPromotedAsset, byte[]> onSuccess;

			private string _003CvideoUrl_003E5__2;

			private UnityWebRequest _003CwebRequest_003E5__3;

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
			public _003CDownloadVideoCoroutine_003Ed__4(int _003C_003E1__state)
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

		private const string TAG = "MercuryDownloader";

		public static void DownloadWaterfall(MercuryWaterfall waterfall, Action<MercuryPromotedAsset> onAssetDownloaded, bool overrideCache)
		{
		}

		private static void OnVideoDownloaded(MercuryPromotedAsset asset, byte[] bytes)
		{
		}

		private static void DownloadVideo(MercuryPromotedAsset asset, Action<MercuryPromotedAsset, byte[]> onSuccess)
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadVideoCoroutine_003Ed__4))]
		private static IEnumerator DownloadVideoCoroutine(MercuryPromotedAsset asset, Action<MercuryPromotedAsset, byte[]> onSuccess)
		{
			return null;
		}
	}
}
