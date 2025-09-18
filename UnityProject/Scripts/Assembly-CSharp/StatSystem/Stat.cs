using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StatSystem
{
	[Serializable]
	public class Stat
	{
		public float BaseValue;

		private bool _isDirty;

		private float _value;

		private float _lastBaseValue;

		private readonly List<StatModifier> statModifiers;

		public readonly ReadOnlyCollection<StatModifier> StatModifiers;

		public float Value => 0f;

		public Stat()
		{
		}

		public Stat(Stat stat)
		{
		}

		public Stat(float baseValue)
		{
		}

		public static implicit operator float(Stat stat)
		{
			return 0f;
		}

		public static implicit operator int(Stat stat)
		{
			return 0;
		}

		public static explicit operator Stat(float value)
		{
			return null;
		}

		private float CalculateFinalValue(float baseValue)
		{
			return 0f;
		}

		private int CompareModifierOrder(StatModifier a, StatModifier b)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void AddModifier(StatModifier mod)
		{
		}

		public bool RemoveModifier(StatModifier mod)
		{
			return false;
		}

		public bool RemoveAllModifiersWithId(short id)
		{
			return false;
		}

		public float ApplyTo(float value)
		{
			return 0f;
		}
	}
}
