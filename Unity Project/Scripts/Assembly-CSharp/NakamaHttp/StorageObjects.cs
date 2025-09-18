using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class StorageObjects
	{
		[DataMember(Name = "objects")]
		[Preserve]
		public List<StorageObject> Objects;

		public StorageObjects()
		{
		}

		public StorageObjects(List<StorageObject> objectsParam)
		{
		}
	}
}
