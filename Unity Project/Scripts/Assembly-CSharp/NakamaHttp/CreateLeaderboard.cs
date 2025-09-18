using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class CreateLeaderboard
	{
		[DataMember(Name = "id")]
		[Preserve]
		public string Id;

		[DataMember(Name = "sort_order")]
		[Preserve]
		public string SortOrder;

		[DataMember(Name = "operator")]
		[Preserve]
		public string Operator;

		[Preserve]
		[DataMember(Name = "title")]
		public string Title;

		public CreateLeaderboard()
		{
		}

		public CreateLeaderboard(string idParam, string sortOrderParam, string operatorParam, string titleParam)
		{
		}
	}
}
