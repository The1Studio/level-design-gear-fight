using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Nakama.TinyJson
{
	public static class JsonParser
	{
		[ThreadStatic]
		private static Stack<List<string>> _splitArrayPool;

		[ThreadStatic]
		private static StringBuilder _stringBuilder;

		[ThreadStatic]
		private static Dictionary<Type, Dictionary<string, FieldInfo>> _fieldInfoCache;

		[ThreadStatic]
		private static Dictionary<Type, Dictionary<string, PropertyInfo>> _propertyInfoCache;

		public static T FromJson<T>(this string json)
		{
			return default(T);
		}

		private static int AppendUntilStringEnd(bool appendEscapeCharacter, int startIdx, string json)
		{
			return 0;
		}

		private static List<string> Split(string json)
		{
			return null;
		}

		private static object ParseValue(Type type, string json)
		{
			return null;
		}

		private static object ParseAnonymousValue(string json)
		{
			return null;
		}

		private static Dictionary<string, T> CreateMemberNameDictionary<T>(IEnumerable<T> members) where T : MemberInfo
		{
			return null;
		}

		private static object ParseObject(Type type, string json)
		{
			return null;
		}
	}
}
