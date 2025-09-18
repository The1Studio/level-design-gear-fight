using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiStorageObjectList
	{
		[DataMember(Name = "cursor")]
		[Preserve]
		public string Cursor { get; set; }

		[DataMember(Name = "objects")]
		[Preserve]
		public List<ApiStorageObject> Objects { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
