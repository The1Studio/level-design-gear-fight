using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Voodoo.Live.Sample.Utils
{
	public class InventoryLabel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayedUpdateLabel_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InventoryLabel _003C_003E4__this;

			public int value;

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
			public _003CDelayedUpdateLabel_003Ed__4(int _003C_003E1__state)
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

		[Header("References")]
		public TextMeshProUGUI labelTxt;

		public InventoryItem inventoryItem;

		private void Start()
		{
		}

		private void UpdateLabel(int value)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedUpdateLabel_003Ed__4))]
		private IEnumerator DelayedUpdateLabel(int value)
		{
			return null;
		}
	}
}
