namespace Voodoo.Sauce.Internal.Analytics
{
	public struct FloatMetric
	{
		public float Min;

		public float Max;

		public float Average;

		public FloatMetric(float min, float max, float average)
		{
			Min = 0f;
			Max = 0f;
			Average = 0f;
		}
	}
}
