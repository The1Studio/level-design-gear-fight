using System;

namespace Items
{
	[Serializable]
	public struct DropRange
	{
		public double Min;

		public double Max;

		public static DropRange Zero;

		public static DropRange One;

		public static DropRange operator *(DropRange s1, double s2)
		{
			return default(DropRange);
		}

		public static DropRange operator *(DropRange s1, DropRange s2)
		{
			return default(DropRange);
		}
	}
}
