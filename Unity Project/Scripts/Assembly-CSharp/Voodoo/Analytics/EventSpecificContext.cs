using System.Collections.Generic;

namespace Voodoo.Analytics
{
	public class EventSpecificContext
	{
		private readonly Dictionary<string, Dictionary<string, object>> _parameters;

		public void Reset()
		{
		}

		public Dictionary<string, object> GetEventParameters(string eventName)
		{
			return null;
		}

		public void Add(string key, string value, List<string> selectedEventNames)
		{
		}

		public void Add(string key, int value, List<string> selectedEventNames)
		{
		}

		public void Add(string key, float value, List<string> selectedEventNames)
		{
		}

		public void Add(string key, bool value, List<string> selectedEventNames)
		{
		}

		private void Add(string key, object value, List<string> selectedEventNames)
		{
		}
	}
}
