using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGiftNew
	{
		[Preserve]
		[DataMember(Name = "amount")]
		public int Amount { get; set; }

		[DataMember(Name = "type")]
		[Preserve]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
