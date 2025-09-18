using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Data.Shop;
using UnityEngine;
using Voodoo.Sauce.IAP;

namespace GearGame.Control
{
	public class ConsumableIAPHandler : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConsumableIAPHandler _003C_003E4__this;

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
			public _003CStart_003Ed__10(int _003C_003E1__state)
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

		private static HashSet<ShopItemMetaBase> _activeTransactions;

		private bool _iapInitialized;

		private bool _sceneLoadInitialized;

		private Tween _pendingCall;

		[field: SerializeField]
		public ConsumableIAPManagerSO IAPManagerSO { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
		private IEnumerator Start()
		{
			return null;
		}

		public static void AddActiveTransaction(ShopItemMetaBase item)
		{
		}

		public static void RemoveActiveTransaction(ShopItemMetaBase item)
		{
		}

		private void PurchaseConcluded(ProductReceivedInfo product, bool status)
		{
		}

		protected virtual void InitializationCompleted(bool status)
		{
		}

		private void TryClearPendingPurchases()
		{
		}
	}
}
