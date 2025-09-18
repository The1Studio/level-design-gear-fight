using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using VInspector;

namespace StatSystem
{
	[Serializable]
	public class Stats
	{
		[SerializeField]
		public SerializedDictionary<StatNames, Stat> StatDictionnary;

		public UnityEvent<StatNames, float> onStatChanged { get; private set; }

		public float this[StatNames type] => 0f;

		public Stats()
		{
		}

		public Stats(Stats stats)
		{
		}

		public Stats(Dictionary<StatNames, Stat> stats)
		{
		}

		public void Add(StatNames type, Stat stat)
		{
		}

		public void AddListener(UnityAction<StatNames, float> listener)
		{
		}

		public void RemoveListener(UnityAction<StatNames, float> listener)
		{
		}

		public void AddModifier(StatNames stat, StatModifier modifier)
		{
		}

		public void RemoveModifiersWithId(short id)
		{
		}

		public void RemoveModifiersWithId(StatNames stat, short id)
		{
		}

		public void Clear()
		{
		}
	}
}
