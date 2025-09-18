using Voodoo.Sauce.Debugger;

namespace Voodoo.Sauce.Ads
{
	[Preserve]
	public class RewardedInterstitialDebugger : CustomDebugger
	{
		public override string GetTitle()
		{
			return null;
		}

		public override int GetOrderIndex()
		{
			return 0;
		}

		public override void SetupScreen(Screen screen)
		{
		}

		private string GetStatus()
		{
			return null;
		}

		private string GetBypassAfterPopUpCount()
		{
			return null;
		}

		private string GetFrequency()
		{
			return null;
		}

		private string GetCapping()
		{
			return null;
		}

		private string GetAbsoluteRewardSoftCurrency()
		{
			return null;
		}

		private string GetAbsoluteRewardHardCurrency()
		{
			return null;
		}

		private string GetRelativeRewardSoftCurrency()
		{
			return null;
		}

		private string GetRelativeRewardHardCurrency()
		{
			return null;
		}

		private string GetRewardSchedule()
		{
			return null;
		}
	}
}
