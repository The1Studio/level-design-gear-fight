using System;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class SDK
	{
		public string name;

		public string icon;

		public SDKVersions versions;

		public override bool Equals(object obj)
		{
			return false;
		}

		public string[] GetVersionsAsArray()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool IsEmpty()
		{
			return false;
		}
	}
}
