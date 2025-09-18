using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleWalletLedger
	{
		[DataMember(Name = "changeset")]
		[Preserve]
		public string Changeset { get; set; }

		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "metadata")]
		public string Metadata { get; set; }

		[Preserve]
		[DataMember(Name = "update_time")]
		public string UpdateTime { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
