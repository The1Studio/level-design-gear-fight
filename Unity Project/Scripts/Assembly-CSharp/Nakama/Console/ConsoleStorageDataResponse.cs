using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleStorageDataResponse
	{
		[Preserve]
		[DataMember(Name = "total_objects_matching")]
		public int TotalObjectsMatching { get; set; }

		[Preserve]
		[DataMember(Name = "user_id_to_storage_json")]
		public Dictionary<string, string> UserIdToStorageJson { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
