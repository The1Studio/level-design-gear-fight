using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Voodoo.Live.Shop.Data;
using Voodoo.Live.Utils;

namespace Voodoo.Live.Sample.Shop.UI
{
	public abstract class ProductUI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayedInit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProductUI _003C_003E4__this;

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
			public _003CDelayedInit_003Ed__9(int _003C_003E1__state)
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
		private TextMeshProUGUI productNameTxt;

		[SerializeField]
		private ButtonProductUI buttonProductUI;

		[SerializeField]
		private TextMeshProUGUI badgeTxt;

		private GameShop _gameShop;

		private RectTransform _scrollViewRect;

		public RectTransform rectTransform;

		private bool _isVisible;

		private Product _product;

		public virtual void Init(Product product, GameShop gameShop, RectTransform scrollViewRect, SpriteDictionarySO spriteDictionarySo)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedInit_003Ed__9))]
		private IEnumerator DelayedInit()
		{
			return null;
		}

		private void OnScroll(Vector2 vector2)
		{
		}

		private void TryToTrackProductShown()
		{
		}

		private bool IsVisible()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
