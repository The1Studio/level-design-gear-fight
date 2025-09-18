using System;
using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class TimeConditions : ICondition
	{
		private string _activationTimeKey;

		public DateTime start;

		public DateTime end;

		public TimeSpan from;

		public TimeSpan to;

		public List<DayOfWeek> activeDays;

		public ActiveTimeType type;

		public int durationInMinutes;

		private DateTime _activationDate;

		private string _errorMessage;

		public string ErrorMessage => null;

		private bool IsActiveAllDayLong => false;

		public TimeConditions(DateTime startDate, DateTime endDate, ActiveTimeConfig activeTime, List<DayOfWeek> day)
		{
		}

		public bool CanUse()
		{
			return false;
		}

		private bool IsInActiveDates(DateTime time)
		{
			return false;
		}

		private bool IsInActiveHours(TimeSpan time)
		{
			return false;
		}

		private bool IsActivationTimeOver(DateTime time)
		{
			return false;
		}

		public bool IsActiveDay(DateTime time)
		{
			return false;
		}

		public bool IsActive(string date = "")
		{
			return false;
		}

		public TimeSpan GetRemainingTime(string date = "")
		{
			return default(TimeSpan);
		}

		private TimeSpan GetRelativeRemainingTime(DateTime now)
		{
			return default(TimeSpan);
		}

		private TimeSpan GetRemainingTimeOfConsecutiveDays(DateTime currentTime)
		{
			return default(TimeSpan);
		}

		private bool IsNextDayActive(DayOfWeek day)
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

		public void SetActivationTime(DateTime activationTime)
		{
		}
	}
}
