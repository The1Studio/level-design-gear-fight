using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class ReadStorageObjectsRequest
	{
		[Preserve]
		[DataMember(Name = "object_ids")]
		public List<ReadStorageObjectId> ObjectIds;

		public ReadStorageObjectsRequest()
		{
		}

		public ReadStorageObjectsRequest(List<ReadStorageObjectId> objectIdsParam)
		{
		}
	}
}
