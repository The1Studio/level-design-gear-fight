using System;

namespace StatSystem
{
	[Serializable]
	public class StatModifier
	{
		public float Value;

		public StatModType Type;

		public int Order;

		public short Id;

		public StatModifier()
		{
		}

		public StatModifier(float value, StatModType type, int order, short id)
		{
		}

		public StatModifier(float value, StatModType type)
		{
		}

		public StatModifier(float value, StatModType type, int order)
		{
		}

		public StatModifier(float value, StatModType type, short id)
		{
		}
	}
}
