using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class DeleteStorageObjectsRequest
	{
		[DataMember(Name = "object_ids")]
		[Preserve]
		public List<DeleteStorageObjectId> ObjectIds;

		public DeleteStorageObjectsRequest()
		{
		}

		public DeleteStorageObjectsRequest(List<DeleteStorageObjectId> objectIdsParam)
		{
		}
	}
}
