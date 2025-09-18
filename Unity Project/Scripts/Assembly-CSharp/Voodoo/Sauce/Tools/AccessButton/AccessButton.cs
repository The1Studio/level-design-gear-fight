using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Tools.AccessButton
{
	public class AccessButton : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRecordingLogoCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AccessButton _003C_003E4__this;

			private Image _003CrecordingImage_003E5__2;

			private Color _003Ccolor_003E5__3;

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
			public _003CRecordingLogoCoroutine_003Ed__7(int _003C_003E1__state)
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
		private GameObject voodooSauceLogo;

		[SerializeField]
		private GameObject recordingLogo;

		[SerializeField]
		private BubbleButton bubbleButton;

		[SerializeField]
		private HidePanel hidePanel;

		private void Start()
		{
		}

		private void SetRecordingAnimationEnabled(bool isRecording)
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CRecordingLogoCoroutine_003Ed__7))]
		private IEnumerator RecordingLogoCoroutine()
		{
			return null;
		}
	}
}
