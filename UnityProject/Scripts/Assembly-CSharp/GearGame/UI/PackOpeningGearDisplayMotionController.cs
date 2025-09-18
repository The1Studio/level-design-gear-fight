using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.UI
{
	public class PackOpeningGearDisplayMotionController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayActivate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PackOpeningGearDisplayMotionController _003C_003E4__this;

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
			public _003CDelayActivate_003Ed__8(int _003C_003E1__state)
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
		private Transform motionTransform;

		[SerializeField]
		private float dampening;

		[SerializeField]
		private float accelerationMultiplier;

		private ScriptableGear gear;

		private Vector3 position;

		private Vector3 currentSpeed;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayActivate_003Ed__8))]
		private IEnumerator DelayActivate()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public void AddImpulse(Vector2 impulse)
		{
		}
	}
}
