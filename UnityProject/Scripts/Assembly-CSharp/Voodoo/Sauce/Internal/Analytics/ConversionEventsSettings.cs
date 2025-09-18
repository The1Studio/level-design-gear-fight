using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class ConversionEventsSettings
	{
		private const int EVENT_NAME_DATA_INDEX = 0;

		private const int EVENT_TRIGGER_DATA_INDEX = 1;

		private const int EVENT_TOKEN_DATA_INDEX = 2;

		private const char DATA_SEPARATOR = '/';

		public bool UseConversionEvents;

		public int DaysUntilExpiration;

		public ConversionAdEventInfo[] AdEvents;

		public ConversionEventInfo[] UnknownEvents;

		public bool IsEnabled()
		{
			return false;
		}

		public bool HasAnyEvents()
		{
			return false;
		}

		public bool HasKnownEvents()
		{
			return false;
		}

		public bool HasValidExpirationDate()
		{
			return false;
		}

		public List<string> GetInvalidEventsData()
		{
			return null;
		}

		public List<string> GetDuplicatedEventsData()
		{
			return null;
		}

		public static ConversionEventsSettings Build(bool useConversionEvents, string daysUntilExpirationValue, IEnumerable<string> eventsValues)
		{
			return null;
		}

		private static ConversionEventInfo BuildEvent(string eventValue)
		{
			return null;
		}

		private static ConversionEventName ParseEventName(string value)
		{
			return default(ConversionEventName);
		}
	}
}
