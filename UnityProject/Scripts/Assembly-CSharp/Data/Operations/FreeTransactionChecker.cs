using Core.Timers;

namespace Data.Operations
{
	public class FreeTransactionChecker : PurchasableChecker
	{
		private Timer _timer;

		public FreeTransactionChecker(string uniqueId)
		{
		}

		private void OnTimerCompleted(Timer obj)
		{
		}

		public override void Dispose()
		{
		}
	}
}
