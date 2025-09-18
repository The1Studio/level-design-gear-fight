namespace Voodoo.Live.Offers
{
	public class FrequencyConditions : ICondition
	{
		private string _triedCountKey;

		private string _TriggerCountKey;

		private string _showOnceKey;

		public int capping;

		public int frequency;

		private bool _shownOnce;

		private int _triedCount;

		private int _triggerCount;

		private string _errorMessage;

		private bool _forceTrigger;

		public string ErrorMessage => null;

		public int TriedCount => 0;

		public int TriggerCount => 0;

		private bool IsFrequencyReached => false;

		private bool IsCappingReached => false;

		public bool CanUse()
		{
			return false;
		}

		public void LinkToFeature(string id)
		{
		}

		public void Reset()
		{
		}

		public void OnFeatureStatusChanged(string status, IFeature feature)
		{
		}

		public void IncrementTries()
		{
		}

		public void ResetTries()
		{
		}

		public void IncrementTrigger()
		{
		}
	}
}
