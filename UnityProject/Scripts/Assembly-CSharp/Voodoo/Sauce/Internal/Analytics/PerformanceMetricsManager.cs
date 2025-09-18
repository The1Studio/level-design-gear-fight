using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Voodoo.Sauce.ThermalState;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class PerformanceMetricsManager
	{
		[CompilerGenerated]
		private sealed class _003CPerformanceMetricsCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float period;

			public PerformanceMetricsManager _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private float _003CminMs_003E5__3;

			private float _003CmaxMs_003E5__4;

			private float _003CnumFrames_003E5__5;

			private int _003CbadFrames_003E5__6;

			private int _003CterribleFrames_003E5__7;

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
			public _003CPerformanceMetricsCoroutine_003Ed__4(int _003C_003E1__state)
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

		private static bool _applicationUnpaused;

		private static ThermalStateService _thermalStateService;

		public static void Initialize(float period, bool enableThermalState)
		{
		}

		internal static void OnApplicationPause(bool pauseStatus)
		{
		}

		[IteratorStateMachine(typeof(_003CPerformanceMetricsCoroutine_003Ed__4))]
		private IEnumerator PerformanceMetricsCoroutine(float period)
		{
			return null;
		}

		private void SendPerformanceMetricsEvent(float minMs, float maxMs, float aveFPS, int badFrames, int terribleFrames, ulong memoryUsed)
		{
		}
	}
}
