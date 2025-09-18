using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiStorageObjects
	{
		[DataMember(Name = "objects")]
		[Preserve]
		public List<ApiStorageObject> Objects { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
