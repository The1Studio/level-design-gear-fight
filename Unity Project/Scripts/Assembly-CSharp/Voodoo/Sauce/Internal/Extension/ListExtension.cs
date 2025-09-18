using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Extension
{
	public static class ListExtension
	{
		public static bool SequenceEqualsIgnoreOrder<T>(this List<T> list1, List<T> list2, Func<T, object> orderBy)
		{
			return false;
		}
	}
}
