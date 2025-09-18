using System;
using System.Collections.Generic;
using NakamaHttp;
using Voodoo.Nakama.Storage;

namespace Voodoo.Nakama.Data
{
	internal class NakamaStorageReader
	{
		private readonly NakamaStorage m_NakamaStorage;

		private Dictionary<string, ServerBaseData> m_LoadingDatas;

		private bool m_ReadingFromCloud;

		public bool CanReadFromCloud => false;

		public NakamaStorageReader(NakamaStorage nakamaStorage)
		{
		}

		public static ServerBaseData CreateFromRawData(Type type, string rawData, NakamaStorage storage)
		{
			return null;
		}

		public void ReadFromLocal(List<ServerBaseData> baseDatas)
		{
		}

		public void ReadFromCloud(Dictionary<string, ServerBaseData> data, Action onComplete)
		{
		}

		private void OnDataReadFromCloud(List<StorageObject> storageObjects, Action onComplete)
		{
		}

		public long ParseNakamaTimestampToUnix(string updateTimeStr)
		{
			return 0L;
		}

		private void EndReading(Action onComplete)
		{
		}

		private static void CreateFromRawData(ServerBaseData data, string rawData, Type dataType)
		{
		}
	}
}
