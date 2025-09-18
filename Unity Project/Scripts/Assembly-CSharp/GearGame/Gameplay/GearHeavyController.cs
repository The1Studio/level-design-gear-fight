using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gameplay._Data;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay
{
	public class GearHeavyController : GearController, IGearProductionUpdater
	{
		[CompilerGenerated]
		private sealed class _003CDelayCheck_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearHeavyController _003C_003E4__this;

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
			public _003CDelayCheck_003Ed__18(int _003C_003E1__state)
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
		private float requiredWeight;

		[SerializeField]
		private Slider fillSlider;

		[SerializeField]
		private TextMeshProUGUI fillPercentText;

		[SerializeField]
		private GameObject activeObject;

		private float targetProgress01;

		private bool pendingValueUpdate;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override GearData GearData => null;

		public override bool CanBeFrozen => false;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		public override void CheckVariableStates()
		{
		}

		public void TriggerPendingValueUpdate()
		{
		}

		private void Check()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayCheck_003Ed__18))]
		private IEnumerator DelayCheck()
		{
			return null;
		}
	}
}
