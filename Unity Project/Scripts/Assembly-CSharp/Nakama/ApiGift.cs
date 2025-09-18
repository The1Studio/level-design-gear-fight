using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGift
	{
		[DataMember(Name = "amount")]
		[Preserve]
		public int Amount { get; set; }

		[DataMember(Name = "created_at")]
		[Preserve]
		public string CreatedAt { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "type")]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
