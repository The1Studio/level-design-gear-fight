using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiStorageObjectAcks
	{
		[DataMember(Name = "acks")]
		[Preserve]
		public List<ApiStorageObjectAck> Acks { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
