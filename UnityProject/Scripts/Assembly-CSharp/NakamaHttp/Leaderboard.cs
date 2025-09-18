using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class Leaderboard
	{
		[Preserve]
		[DataMember(Name = "id")]
		public string Id;

		[DataMember(Name = "sort_order")]
		[Preserve]
		public int SortOrder;

		[Preserve]
		[DataMember(Name = "operator")]
		public Operator Operator;

		[Preserve]
		[DataMember(Name = "title")]
		public string Title;

		public Leaderboard()
		{
		}

		public Leaderboard(string idParam, int sortOrderParam, Operator operatorParam, string titleParam)
		{
		}
	}
}
