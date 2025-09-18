using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Core.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Control
{
	public class TroopPackGearUnlockingCanvasController : Popup
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public RankedGearDisplayController r;

			public TroopPackGearUnlockingCanvasController _003C_003E4__this;

			internal void _003CMoveToPosition_003Eb__0()
			{
			}

			internal void _003CMoveToPosition_003Eb__1()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CMoveToPosition_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RankedGearDisplayController r;

			public TroopPackGearUnlockingCanvasController _003C_003E4__this;

			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

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
			public _003CMoveToPosition_003Ed__16(int _003C_003E1__state)
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
		private RankedGearDisplayController displayControllerPrefab;

		[SerializeField]
		private RectTransform motionTransform;

		[SerializeField]
		private RectTransform spawnTransform;

		[SerializeField]
		private TextMeshProUGUI titleText;

		[SerializeField]
		private TextMeshProUGUI rankText;

		[SerializeField]
		private string localizationString;

		[SerializeField]
		private float motionDuration;

		[SerializeField]
		private float delay;

		[SerializeField]
		private AnimationCurve curve;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Transform layoutStartPosition;

		[SerializeField]
		private AudioSource reachedDestinationSource;

		[SerializeField]
		private AudioSourceVariable passedCenterSource;

		private List<RectTransform> clickSoundOffsets;

		private List<RankedGearDisplayController> allGears;

		public void Initialize(ScriptablePack pack)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveToPosition_003Ed__16))]
		private IEnumerator MoveToPosition(RankedGearDisplayController r)
		{
			return null;
		}
	}
}
