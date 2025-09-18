using System.Collections.Generic;

namespace Voodoo.Sauce.CrashReport.Embrace
{
	internal class EmbraceStoredValues
	{
		public string userId;

		public bool isPayer;

		public readonly List<string> personas;

		public readonly Dictionary<string, string> sessionProperties;

		public readonly List<object> logs;
	}
}
