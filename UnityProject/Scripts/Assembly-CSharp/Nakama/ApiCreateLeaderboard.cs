using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCreateLeaderboard
	{
		[DataMember(Name = "authoritative")]
		[Preserve]
		public bool Authoritative { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "operator")]
		public string Operator { get; set; }

		[Preserve]
		[DataMember(Name = "sort_order")]
		public string SortOrder { get; set; }

		[Preserve]
		[DataMember(Name = "title")]
		public string Title { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
