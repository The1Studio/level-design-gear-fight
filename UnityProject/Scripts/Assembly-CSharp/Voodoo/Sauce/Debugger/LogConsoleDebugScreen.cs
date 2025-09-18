using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Debugger
{
	public class LogConsoleDebugScreen : Screen
	{
		[Serializable]
		internal class LogTypeFields
		{
			public Toggle toggle;

			public Color color;

			public TextMeshProUGUI titleText;

			[NonSerialized]
			public int count;
		}

		[SerializeField]
		private Transform issueListItemParent;

		[SerializeField]
		private DebugLogMessageListItem issueListItemPrefab;

		[SerializeField]
		private DebugLogMessagePopup logMessagePopup;

		[SerializeField]
		private Button clearAllButton;

		[SerializeField]
		private Button optionButton;

		[SerializeField]
		private LogsOptionDebugScreen optionScreen;

		[SerializeField]
		private ScrollRect issuesScrollRect;

		[SerializeField]
		private Button scrollDownButton;

		[SerializeField]
		private TMP_InputField searchInputField;

		[SerializeField]
		private TextMeshProUGUI searchCountText;

		[SerializeField]
		private LogTypeFields exceptionFields;

		[SerializeField]
		private LogTypeFields errorFields;

		[SerializeField]
		private LogTypeFields warningFields;

		private static string _searchString;

		private Dictionary<LogType, LogTypeFields> _logTypeDict;

		private readonly List<DebugLogMessageListItem> _issueMessageList;

		public static Action Closed;

		private void Awake()
		{
		}

		private void OnLogEnableChange(bool value)
		{
		}

		private void OnDestroy()
		{
		}

		private int CountActiveMessageListItems()
		{
			return 0;
		}

		private void OnSearchEndEdit(string searchString)
		{
		}

		private void UpdateMessageList()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void InitIssuesList()
		{
		}

		private void ShowLogMessagePopup(LogMessage logMessage)
		{
		}

		private void SetLogTypeCount(LogType logType, int count = -1)
		{
		}

		private void IncrementLogTypeCount(LogType logType)
		{
		}

		private void ToggleLogType(bool isActive, LogType logType)
		{
		}

		private void ClearExceptionsList()
		{
		}

		private void LogsTrackerOnIssueMessageReceived(LogMessage issueMessage)
		{
		}

		private DebugLogMessageListItem AddLogMessage(LogMessage issueMessage)
		{
			return null;
		}

		private void OnMessageListClicked(LogMessage logMessage)
		{
		}

		public static bool MessageMatchesSearchText(LogMessage issueMessage)
		{
			return false;
		}

		private void UpdateSearchCountText(int count)
		{
		}

		public override BadgeCounter Counter()
		{
			return null;
		}
	}
}
