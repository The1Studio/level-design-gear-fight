using System;
using System.Collections.Generic;

namespace SaveSystem
{
	public class IDTable
	{
		private readonly Dictionary<Type, HashSet<string>> _typeToIDListDict;

		public bool Contains<T>(string id)
		{
			return false;
		}
	}
}
