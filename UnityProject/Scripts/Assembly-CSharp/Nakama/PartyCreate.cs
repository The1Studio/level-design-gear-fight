using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyCreate
	{
		[DataMember(Name = "open")]
		[Preserve]
		public bool Open { get; set; }

		[DataMember(Name = "max_size")]
		[Preserve]
		public int MaxSize { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
