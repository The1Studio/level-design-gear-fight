using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Debugger
{
	public class EventConsoleListScreen : Screen
	{
		[CompilerGenerated]
		private sealed class _003CRefreshOnEnable_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EventConsoleListScreen _003C_003E4__this;

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
			public _003CRefreshOnEnable_003Ed__22(int _003C_003E1__state)
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

		private const string DEFAULT_WRAPPER_NAME_FILTER = "VoodooAnalytics";

		[Header("EventConsole")]
		[SerializeField]
		private EventConsoleInformationScreen eventInformationScreen;

		[SerializeField]
		private EventConsoleFiltersScreen eventFiltersScreen;

		[SerializeField]
		private Transform sessionContainer;

		[SerializeField]
		private Button recordButton;

		[SerializeField]
		private Button flushButton;

		[SerializeField]
		private Button filterButton;

		[SerializeField]
		private Image recordingImage;

		[SerializeField]
		private Image pauseImage;

		[SerializeField]
		private Button recordAtStartupBtnOn;

		[SerializeField]
		private Button recordAtStartupBtnOff;

		[SerializeField]
		[Header("Prefab")]
		private EventConsoleItem eventLogItemPrefab;

		[SerializeField]
		private EventConsoleSessionItem sessionItemPrefab;

		private static readonly ConcurrentQueue<Action> _runOnMainThread;

		private readonly Dictionary<string, EventConsoleItem> _eventDictionary;

		private readonly Dictionary<string, EventConsoleSessionItem> _sessionDictionary;

		private readonly Stack<EventConsoleItem> _eventPool;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CRefreshOnEnable_003Ed__22))]
		private IEnumerator RefreshOnEnable()
		{
			return null;
		}

		private static void EnableAnalyticsLoggingAndDebugging(bool isEnabled)
		{
		}

		private static void UpdateButtonState(bool enable, Selectable button, Graphic buttonIcon)
		{
		}

		private void ShowFiltersScreen()
		{
		}

		internal void RefreshEventLogToScreen()
		{
		}

		private void HandleNewEventEmitted(DebugAnalyticsLog log, bool isUpdateFromExisting)
		{
		}

		private void DisplayEvent(DebugAnalyticsLog log)
		{
		}

		private void CreateEvent(DebugAnalyticsLog log)
		{
		}

		private void ShowEventDescription(DebugAnalyticsLog log)
		{
		}

		private void RefreshSessionsSize()
		{
		}

		private void UpdateEvent(DebugAnalyticsLog log)
		{
		}

		private EventConsoleSessionItem CreateSession(string sessionId)
		{
			return null;
		}

		private void FlushLog()
		{
		}

		private void RecordPressed()
		{
		}

		private void OnRecordAtStartupBtnClick()
		{
		}

		private void UpdateRecordAtStartupBtnDisplay()
		{
		}

		private void UpdateRecordButtonState()
		{
		}
	}
}
