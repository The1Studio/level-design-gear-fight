using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaconsoleLeaderboard
	{
		[DataMember(Name = "create_time")]
		[Preserve]
		public string CreateTime { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "operator")]
		public int Operator { get; set; }

		[Preserve]
		[DataMember(Name = "sort_order")]
		public int SortOrder { get; set; }

		[DataMember(Name = "title")]
		[Preserve]
		public string Title { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
