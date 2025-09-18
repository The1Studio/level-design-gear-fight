using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiDeleteStorageObjectsRequest
	{
		[Preserve]
		[DataMember(Name = "object_ids")]
		public List<ApiDeleteStorageObjectId> ObjectIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
