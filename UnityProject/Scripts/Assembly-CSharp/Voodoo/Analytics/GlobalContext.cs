using System;
using System.Collections.Generic;

namespace Voodoo.Analytics
{
	public class GlobalContext
	{
		[Serializable]
		internal struct CachedKeys
		{
			public List<string> keys;
		}

		private readonly Dictionary<string, object> _parameters;

		private const string K_PREFS_CACHED_PARAMETERS = "GlobalContext_CachedParameters";

		private const string K_PREFS_CACHED_PARAMETERS_KEY = "GlobalContext_CachedParameters_Key_{0}";

		public void Reset()
		{
		}

		public Dictionary<string, object> GetParameters()
		{
			return null;
		}

		public void AddCache(string key, string value)
		{
		}

		public void Add(string key, string value)
		{
		}

		public void Add(string key, int value)
		{
		}

		public void Add(string key, float value)
		{
		}

		public void Add(string key, bool value)
		{
		}

		private void AddParameterToCache(string key, string value)
		{
		}

		private CachedKeys GetCachedKeys()
		{
			return default(CachedKeys);
		}

		private Dictionary<string, string> GetCachedParameters()
		{
			return null;
		}

		private string GetPrefsKey(string key)
		{
			return null;
		}

		public string GetCachedValue(string key)
		{
			return null;
		}

		private void SetCachedValue(string key, string value)
		{
		}

		public void DeleteAllCachedValues()
		{
		}
	}
}
