using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Voodoo.Sauce.Internal.CrossPromo.Canvas
{
	internal class DefaultFormat : AFormatManager
	{
		[CompilerGenerated]
		private sealed class _003CStartDisplay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DefaultFormat _003C_003E4__this;

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
			public _003CStartDisplay_003Ed__9(int _003C_003E1__state)
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

		private TextMeshProUGUI _gameName;

		private VideoManager _videoManager;

		[SerializeField]
		private GameObject _adLabel;

		[SerializeField]
		public RectTransform myCanvasTransformer;

		private static RectTransform _transformer;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public override void Display()
		{
		}

		[IteratorStateMachine(typeof(_003CStartDisplay_003Ed__9))]
		private IEnumerator StartDisplay()
		{
			return null;
		}

		public static Vector3 RectTransformToScreenSpace()
		{
			return default(Vector3);
		}

		public override void Hide()
		{
		}

		private void Enable(bool show)
		{
		}
	}
}
