using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpUnit
	{
		[DataMember(Name = "id")]
		[Preserve]
		public int Id { get; set; }

		[DataMember(Name = "level")]
		[Preserve]
		public int Level { get; set; }

		[DataMember(Name = "overall_max_available_level")]
		[Preserve]
		public int OverallMaxAvailableLevel { get; set; }

		[Preserve]
		[DataMember(Name = "overall_max_unlocked_id")]
		public int OverallMaxUnlockedId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
