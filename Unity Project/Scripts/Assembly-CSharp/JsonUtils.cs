using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

public static class JsonUtils
{
	public static string AddToJson(string json, string key, string value)
	{
		return null;
	}

	public static string AddToJson(string json, string key, int value)
	{
		return null;
	}

	public static string AddToJson(string json, string key, double value)
	{
		return null;
	}

	private static string ReplaceLastOccurrence(string json, string oldValue, string newValue)
	{
		return null;
	}

	[CanBeNull]
	internal static Dictionary<string, object> DeserializeAsDictionary(string json)
	{
		return null;
	}

	[CanBeNull]
	private static Dictionary<string, object> JObjectToDictionary(JObject jObject)
	{
		return null;
	}
}
