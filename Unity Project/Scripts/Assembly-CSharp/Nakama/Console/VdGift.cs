using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class VdGift
	{
		[DataMember(Name = "amount")]
		[Preserve]
		public int Amount { get; set; }

		[Preserve]
		[DataMember(Name = "created_at")]
		public string CreatedAt { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "type")]
		[Preserve]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
