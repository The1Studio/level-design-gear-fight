using System.Collections.Generic;

namespace Voodoo.Analytics
{
	internal static class AnalyticsUtil
	{
		private const string TAG = "Analytics - Util";

		private const string CONTEXT_VAR_REGEXP_PATTERN = "^[a-z_][a-z_0-9]*$";

		internal static string ConvertDictionaryToJson(Dictionary<string, object> eventCustomData, string dataJson = null, string customVariables = null, string contextVariables = null)
		{
			return null;
		}

		internal static string ConvertDictionaryToCustomVarJson(Dictionary<string, object> eventCustomVariables)
		{
			return null;
		}

		internal static string ConvertDictionaryToContextVarJson(Dictionary<string, object> eventContextVariables)
		{
			return null;
		}

		private static object CheckValue(object obj)
		{
			return null;
		}
	}
}
