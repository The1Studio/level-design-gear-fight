using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class WriteStorageObjectsRequest
	{
		[DataMember(Name = "objects")]
		[Preserve]
		public List<WriteStorageObject> Objects;

		public WriteStorageObjectsRequest()
		{
		}

		public WriteStorageObjectsRequest(List<WriteStorageObject> objectsParam)
		{
		}
	}
}
