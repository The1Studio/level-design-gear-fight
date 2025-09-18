using System;
using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public interface IGameplaySaveLoad
	{
		[Serializable]
		public class SaveChunk
		{
			[field: SerializeField]
			public string ID { get; private set; }

			[field: SerializeField]
			public string Data { get; private set; }

			public SaveChunk(string iD, string data)
			{
			}
		}

		[Serializable]
		public class SaveData
		{
			[field: SerializeField]
			public string ID { get; private set; }

			[field: SerializeField]
			public SaveChunk[] Chunks { get; private set; }

			public SaveData(string iD, SaveChunk[] chunks)
			{
			}
		}

		string ID { get; }

		void SetSaveData(SaveData data);

		protected SaveChunk[] GetSaveData();

		SaveData GetSave()
		{
			return null;
		}

		static string GetData(ref SaveData data, string id)
		{
			return null;
		}

		bool Validate(SaveData data)
		{
			return false;
		}
	}
}
