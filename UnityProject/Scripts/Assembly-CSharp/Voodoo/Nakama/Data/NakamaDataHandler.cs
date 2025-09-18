using System;
using System.Collections.Generic;
using NakamaHttp;
using Voodoo.Nakama.Server;
using Voodoo.Nakama.Storage;

namespace Voodoo.Nakama.Data
{
	public class NakamaDataHandler : IDisposable
	{
		private readonly NakamaStorage m_NakamaStorage;

		private readonly DataWriter m_Writer;

		private readonly DataReader m_Reader;

		public NakamaDataHandler(NakamaServer nakama)
		{
		}

		public void Tick()
		{
		}

		public void Dispose()
		{
		}

		public void Load(Dictionary<string, ServerBaseData> datas, Action onComplete)
		{
		}

		public void Save(Dictionary<string, ServerBaseData> datas)
		{
		}

		public ServerBaseData CreateFromRawData(Type type, string rawData)
		{
			return null;
		}

		public void WriteLocalData(List<StorageObject> newStorage)
		{
		}

		public void ForceSavePendingData()
		{
		}

		public void CleanLocalData()
		{
		}
	}
}
