using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class VdGiftNew
	{
		[DataMember(Name = "amount")]
		[Preserve]
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
