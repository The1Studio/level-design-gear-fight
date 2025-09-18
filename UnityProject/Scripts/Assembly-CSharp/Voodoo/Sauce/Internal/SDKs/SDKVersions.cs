using System;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class SDKVersions
	{
		public string unity;

		public string ios;

		public string android;

		public string[] GetVersionsAsArray()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
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
