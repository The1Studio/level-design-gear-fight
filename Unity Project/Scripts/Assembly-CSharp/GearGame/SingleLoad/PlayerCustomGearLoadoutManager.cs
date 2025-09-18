using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.SingleLoad
{
	public class PlayerCustomGearLoadoutManager : MonoBehaviour
	{
		public enum TryEquipResult
		{
			Success = 0,
			Locked = 1,
			Full = 2
		}

		private static PlayerCustomGearLoadoutManager instance;

		[SerializeField]
		private int[] allGearSlotUnlockLevels;

		private ScriptableGear[] selectedGears;

		public static PlayerCustomGearLoadoutManager Instance => null;

		public IList<ScriptableGear> SelectedGears => null;

		public ScriptableGear[] AllCustomGears { get; private set; }

		public ScriptableGear[] AllGearsInGame { get; private set; }

		public event Action<IList<ScriptableGear>> OnLoadoutChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Save(IList<ScriptableGear> list)
		{
		}

		public int GetTotalSlots()
		{
			return 0;
		}

		public Tuple<bool, int> GetUnlockDetails(int index)
		{
			return null;
		}

		public bool IsSelected(ScriptableGear gear)
		{
			return false;
		}

		public void RemoveGear(int index)
		{
		}

		public void SwapGear(int index, ScriptableGear gear)
		{
		}

		public TryEquipResult OnClick(ScriptableGear gear)
		{
			return default(TryEquipResult);
		}
	}
}
