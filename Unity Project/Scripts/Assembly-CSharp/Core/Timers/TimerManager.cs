using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Core.Timers
{
	public class TimerManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadTimers_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimerManager _003C_003E4__this;

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
			public _003CLoadTimers_003Ed__8(int _003C_003E1__state)
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

		private static TimerManager _instance;

		private List<Timer> _timers;

		private float _lastTime;

		private int _ids;

		private void Awake()
		{
		}

		private void OnRealtimeLoaded()
		{
		}

		private void LoadOldSaveToCurrentSave()
		{
		}

		private void LoadNewSave()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadTimers_003Ed__8))]
		private IEnumerator LoadTimers()
		{
			return null;
		}

		private void Update()
		{
		}

		private void RemoveTimer(Timer timer)
		{
		}

		public static void CheatClearAllTimers()
		{
		}

		public static void CheatProgressTimer(TimeSpan timeSpan)
		{
		}

		public static Timer New(TimeSpan duration, string tag = "", DateTime? startTime = null)
		{
			return null;
		}

		public static bool TryGet(string tag, out Timer timer)
		{
			timer = null;
			return false;
		}
	}
}
