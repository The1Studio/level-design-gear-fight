using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Live.Offers
{
	public class SpinConditions : ICondition
	{
		private string _rerollLimitReachedDateKey;

		private DateTime _rerollLimitReachedDate;

		private TimeSpan _rerollCooldown;

		public string ErrorMessage { get; }

		public event Action cooldownOver
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public SpinConditions(TimeSpan rerollCooldown)
		{
		}

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

		public void SetLimitReached(DateTime activationTime)
		{
		}
	}
}
