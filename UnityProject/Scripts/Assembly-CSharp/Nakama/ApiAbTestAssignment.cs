using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestAssignment
	{
		[DataMember(Name = "case")]
		[Preserve]
		public string Case { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[DataMember(Name = "version")]
		[Preserve]
		public int Version { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
