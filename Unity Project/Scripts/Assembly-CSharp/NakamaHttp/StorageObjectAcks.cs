using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StorageObjectAcks
	{
		[DataMember(Name = "acks")]
		[Preserve]
		public List<StorageObjectAck> Acks;

		public StorageObjectAcks()
		{
		}

		public StorageObjectAcks(List<StorageObjectAck> acksParam)
		{
		}
	}
}
