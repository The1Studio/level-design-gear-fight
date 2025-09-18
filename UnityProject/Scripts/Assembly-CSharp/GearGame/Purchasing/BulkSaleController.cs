using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.Timers;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Purchasing
{
	public class BulkSaleController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRebuildParent_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BulkSaleController _003C_003E4__this;

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
			public _003CRebuildParent_003Ed__13(int _003C_003E1__state)
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

		[SerializeField]
		private GameObject bulkOfferingPrefab;

		[SerializeField]
		private LayoutGroup spawnTransform;

		[SerializeField]
		private ScriptableBulkSaleCollection[] allOfferingCollections;

		[SerializeField]
		private float discountPerOwned;

		[SerializeField]
		private TextMeshProUGUI timerText;

		private readonly List<BulkOfferingItem> allOfferings;

		private Timer timer;

		private void Start()
		{
		}

		private void TimeChanged(Timer timer)
		{
		}

		private void TimerElapsed(Timer timer)
		{
		}

		private void Initialize()
		{
		}

		private void StartNewOfferBundle(int index, bool isNewOffering)
		{
		}

		private void SpawnOffering(ScriptableBulkSaleCollection offering)
		{
		}

		[IteratorStateMachine(typeof(_003CRebuildParent_003Ed__13))]
		private IEnumerator RebuildParent()
		{
			return null;
		}

		private void OfferPurchased(BulkOfferingItem item)
		{
		}

		private void RefreshDiscounts()
		{
		}
	}
}
