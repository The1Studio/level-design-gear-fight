using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleStorageCollectionsList
	{
		[DataMember(Name = "collections")]
		[Preserve]
		public List<string> Collections { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
