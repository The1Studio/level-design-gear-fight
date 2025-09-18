namespace Voodoo.Sauce.Debugger
{
	public class IssuesCounter : BadgeCounter
	{
		private int _issuesCount;

		public override void Start()
		{
		}

		public override void Stop()
		{
		}

		private void Refresh()
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
