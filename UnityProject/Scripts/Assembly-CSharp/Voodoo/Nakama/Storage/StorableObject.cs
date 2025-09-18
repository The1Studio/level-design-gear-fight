using System;

namespace Voodoo.Nakama.Storage
{
	public struct StorableObject
	{
		public Type Type;

		public string Data;

		public string Version;

		public string Key => null;
	}
}
