using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleStorageDataRequest
	{
		[DataMember(Name = "collection_name")]
		[Preserve]
		public string CollectionName { get; set; }

		[DataMember(Name = "key_name")]
		[Preserve]
		public string KeyName { get; set; }

		[DataMember(Name = "min_update_epoch_seconds")]
		[Preserve]
		public long MinUpdateEpochSeconds { get; set; }

		[Preserve]
		[DataMember(Name = "num_objects")]
		public int NumObjects { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
