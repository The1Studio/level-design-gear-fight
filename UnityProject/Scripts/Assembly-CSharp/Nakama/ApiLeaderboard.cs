using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiLeaderboard
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "operator")]
		[Preserve]
		public ApiOperator Operator { get; set; }

		[DataMember(Name = "sort_order")]
		[Preserve]
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
