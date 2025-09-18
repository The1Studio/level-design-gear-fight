using System;
using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public class GameProgressSaveManager : MonoBehaviour
	{
		[Serializable]
		public class AllSaves
		{
			[field: SerializeField]
			public IGameplaySaveLoad.SaveData[] AllData { get; private set; }

			[field: SerializeField]
			public string VersionCode { get; private set; }

			public AllSaves(IGameplaySaveLoad.SaveData[] allData, string versionCode)
			{
			}
		}

		private Action _setStoreDelegate;

		public void AssignSetStoreDelegate(Action setStoreDelegate)
		{
		}

		private void ForceTryLoad(string s)
		{
		}

		public void Save()
		{
		}

		private bool Validate(string loadString)
		{
			return false;
		}

		public bool TryLoad(string loadString)
		{
			return false;
		}
	}
}
