using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.Analytics;

namespace Voodoo.Sauce.Debugger
{
	public class EventConsoleInformationScreen : Screen
	{
		private const string DEFAULT_HEADER_FIELDS = "other header fields";

		private const string EVENT_DATE_FORMAT = "dd/MM/yyyy HH:mm:ss";

		[SerializeField]
		[Header("Console Information")]
		private EventConsoleErrorScreen errorScreen;

		[SerializeField]
		private EventInformationList eventInformationListPrefab;

		[SerializeField]
		private EventInformationLineItem eventInformationLineItemPrefab;

		[SerializeField]
		private TextMeshProUGUI eventName;

		[SerializeField]
		private TextMeshProUGUI eventDate;

		[SerializeField]
		private GameObject eventSendingStatus;

		[SerializeField]
		private GameObject eventSentStatus;

		[SerializeField]
		private GameObject eventErrorStatus;

		[SerializeField]
		private Transform eventInformationContainer;

		[SerializeField]
		private Button eventCopyJson;

		[SerializeField]
		private Button eventSeeError;

		private readonly Dictionary<string, EventInformationList> _eventInformationListDictionary;

		private readonly Stack<EventInformationLineItem> _eventInformationLinePool;

		private void OnEnable()
		{
		}

		private EventInformationList CreateEventInformationList(string title)
		{
			return null;
		}

		private void CreateEventInformationLine(KeyValuePair<string, object> information, Transform parent)
		{
		}

		private void UpdateEventInformationHeader(DebugAnalyticsLog log)
		{
		}

		private void UpdateEventInformationBody(DebugAnalyticsLog log)
		{
		}

		private void OnErrorClicked(DebugAnalyticsLog log)
		{
		}

		public void ShowEventDescription(DebugAnalyticsLog log)
		{
		}

		private void CleanEventInformationBody()
		{
		}

		private void RefreshInformationSize()
		{
		}

		private static void CopyEventJson(DebugAnalyticsLog log)
		{
		}
	}
}
