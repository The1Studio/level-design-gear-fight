using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Canvas
{
	internal abstract class AFormatManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitCrossPromoReady_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AFormatManager _003C_003E4__this;

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
			public _003CWaitCrossPromoReady_003Ed__12(int _003C_003E1__state)
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

		public static AFormatManager Instance;

		protected AssetModel Asset;

		protected bool IsActive;

		protected bool IsWaiting;

		private const string ITUNES_URL = "https://itunes.apple.com/fr/app/apple-store/id{0}";

		private const string PLAYSTORE_URL = "https://play.google.com/store/apps/details?id={0}";

		public abstract void Display();

		public virtual void OnClickEvent()
		{
		}

		private void SendTrackingLink(string trackingLink)
		{
		}

		private void OpenAppStoreUsingId(long appleId, string bundleId)
		{
		}

		private void OpenAppStoreUsingUrl(string url)
		{
		}

		public abstract void Hide();

		[IteratorStateMachine(typeof(_003CWaitCrossPromoReady_003Ed__12))]
		protected IEnumerator WaitCrossPromoReady()
		{
			return null;
		}
	}
}
