using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiWriteStorageObjectsRequest
	{
		[Preserve]
		[DataMember(Name = "objects")]
		public List<ApiWriteStorageObject> Objects { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
