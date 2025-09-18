using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class RerollLimitReachedEvent : SpinEvent
	{
		private const string Max_Threshold = "max_spin_threshold";

		private readonly string _max_spin_threshold;

		private static string eventName;

		public RerollLimitReachedEvent(string offerId, string maxSpinThreshold)
			: base(null, null)
		{
		}

		protected override void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
