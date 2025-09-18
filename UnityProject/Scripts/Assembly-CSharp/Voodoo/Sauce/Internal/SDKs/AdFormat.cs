using System;

namespace Voodoo.Sauce.Internal.SDKs
{
	[Serializable]
	public class AdFormat
	{
		public string className;

		public string customData;

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
