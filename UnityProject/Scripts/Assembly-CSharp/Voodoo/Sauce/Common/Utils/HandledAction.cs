using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Common.Utils
{
	public class HandledAction<T>
	{
		private readonly List<Action<T>> _actions;

		private readonly string _tag;

		public HandledAction(string tag)
		{
		}

		public void Invoke(T t)
		{
		}

		public void Add(Action<T> action)
		{
		}

		public void Remove(Action<T> action)
		{
		}

		public void Clear()
		{
		}
	}
}
