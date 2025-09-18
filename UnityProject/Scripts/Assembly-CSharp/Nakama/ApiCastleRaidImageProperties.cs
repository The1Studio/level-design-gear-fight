using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidImageProperties
	{
		[DataMember(Name = "animal")]
		[Preserve]
		public int Animal { get; set; }

		[DataMember(Name = "frame")]
		[Preserve]
		public int Frame { get; set; }

		[Preserve]
		[DataMember(Name = "item")]
		public int Item { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
