using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildInfo
	{
		[Preserve]
		[DataMember(Name = "capacity")]
		public int Capacity { get; set; }

		[Preserve]
		[DataMember(Name = "description")]
		public string Description { get; set; }

		[Preserve]
		[DataMember(Name = "is_fake")]
		public bool IsFake { get; set; }

		[DataMember(Name = "logo")]
		[Preserve]
		public string Logo { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[DataMember(Name = "permission")]
		[Preserve]
		public ApiGuildJoiningPermissions Permission { get; set; }

		[Preserve]
		[DataMember(Name = "required_points")]
		public int RequiredPoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
