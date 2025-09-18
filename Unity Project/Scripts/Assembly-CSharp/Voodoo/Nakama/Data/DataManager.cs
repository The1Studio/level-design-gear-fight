using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NakamaHttp;

namespace Voodoo.Nakama.Data
{
	public class DataManager : IDisposable
	{
		private readonly Dictionary<string, ServerBaseData> m_DatasToLoad;

		private readonly Dictionary<Type, ServerBaseData> m_DataByTypes;

		private readonly Dictionary<string, ServerBaseData> m_DataToSave;

		private NakamaDataHandler m_DataHandler;

		private bool m_IsInitialized;

		private Dictionary<string, Action> m_LoadDataCallbacks;

		public Dictionary<Type, ServerBaseData> DataByTypes => null;

		public void SetDataManager(NakamaDataHandler dataHandler)
		{
		}

		[PublicAPI]
		public void AddDataToSystem<T>(Action onLoadCallback = null) where T : ServerBaseData, new()
		{
		}

		[PublicAPI]
		public T GetData<T>() where T : ServerBaseData
		{
			return null;
		}

		[PublicAPI]
		public void ReplaceData<T>(T newData) where T : ServerBaseData
		{
		}

		public void LoadAll(Action finishCallback)
		{
		}

		public ServerBaseData CreateFromRawData(Type type, string rawData)
		{
			return null;
		}

		public void ClearOldDataAndWriteNewOne(List<StorageObject> newStorage)
		{
		}

		public void Tick()
		{
		}

		public void Dispose()
		{
		}

		private void OnDataLoaded(ServerBaseData data)
		{
		}

		private void AddDataToSave(ServerBaseData data)
		{
		}

		public void SavePendingData(bool force = false)
		{
		}

		private void CleanSystem()
		{
		}

		public void ClearData()
		{
		}
	}
}
