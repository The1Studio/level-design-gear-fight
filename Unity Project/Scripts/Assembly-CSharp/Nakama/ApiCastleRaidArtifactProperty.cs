using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCastleRaidArtifactProperty
	{
		[DataMember(Name = "percent")]
		[Preserve]
		public int Percent { get; set; }

		[DataMember(Name = "property_type")]
		[Preserve]
		public int PropertyType { get; set; }

		[DataMember(Name = "value")]
		[Preserve]
		public int Value { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
