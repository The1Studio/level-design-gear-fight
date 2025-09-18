using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiReadStorageObjectsRequest
	{
		[Preserve]
		[DataMember(Name = "object_ids")]
		public List<ApiReadStorageObjectId> ObjectIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
