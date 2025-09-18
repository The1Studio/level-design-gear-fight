using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Extension
{
	public static class DictionaryExtension
	{
		public static void AddIfNotNull(this Dictionary<string, object> dic, string key, object value)
		{
		}

		public static void AddIfNotNull<T>(this Dictionary<string, object> dic, string key, T? value) where T : struct
		{
		}

		public static void AddIfNotNull(this Dictionary<string, object> dic, string key, Enum value, string defaultValue = null)
		{
		}

		public static void AddIfNotNull(this Dictionary<string, object> dic, string key, string value, string defaultValue = null)
		{
		}

		public static string ToJson(this Dictionary<string, object> dic)
		{
			return null;
		}

		public static Dictionary<string, object> RemoveNullValues(this Dictionary<string, object> dic)
		{
			return null;
		}
	}
}
