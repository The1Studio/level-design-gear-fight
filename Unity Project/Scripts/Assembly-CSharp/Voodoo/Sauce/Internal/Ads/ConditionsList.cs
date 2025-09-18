using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Ads
{
	public class ConditionsList
	{
		private readonly List<Func<string, bool>> _conditions;

		public void Add(Func<string, bool> condition)
		{
		}

		public bool CheckConditions(string adUnit)
		{
			return false;
		}
	}
}
