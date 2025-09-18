using System.Collections.Generic;
using Voodoo.Nakama.Storage;

namespace Voodoo.Nakama.Data
{
	internal class DataWriter
	{
		private readonly NakamaStorageWriter m_Writer;

		private readonly Dictionary<string, ServerBaseData> m_CloudPendingSaveDatas;

		public DataWriter(NakamaStorage nakamaStorage)
		{
		}

		public void Save(Dictionary<string, ServerBaseData> datas)
		{
		}

		public void Tick()
		{
		}

		private void OnNextBatchCallback()
		{
		}

		private void AddToCloudPendingData(Dictionary<string, ServerBaseData> datas)
		{
		}

		private void RemoveCloudPendingToSaveData(List<string> keys)
		{
		}

		public void ForceWriteDataToCloud()
		{
		}

		public void Dispose()
		{
		}
	}
}
