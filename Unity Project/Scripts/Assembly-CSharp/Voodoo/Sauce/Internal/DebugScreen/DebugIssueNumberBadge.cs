using TMPro;
using UnityEngine;
using Voodoo.Sauce.Debugger;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public class DebugIssueNumberBadge : MonoBehaviour
	{
		private const string TAG = "DebugIssueNumberBadge";

		[SerializeField]
		private TextMeshProUGUI numberText;

		[SerializeField]
		private bool hideIfEmpty;

		[SerializeField]
		private GameObject badgeObject;

		private int _issuesCount;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshCounts()
		{
		}

		private void LogsTrackerOnIssueMessageReceived(LogMessage issueMessage)
		{
		}

		private static bool MustIssueBeCounted(LogMessage issueMessage)
		{
			return false;
		}
	}
}
