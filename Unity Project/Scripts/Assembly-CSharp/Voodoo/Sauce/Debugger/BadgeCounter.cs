using System;

namespace Voodoo.Sauce.Debugger
{
	public abstract class BadgeCounter
	{
		public Action<int> update;

		public abstract void Start();

		public abstract void Stop();
	}
}
