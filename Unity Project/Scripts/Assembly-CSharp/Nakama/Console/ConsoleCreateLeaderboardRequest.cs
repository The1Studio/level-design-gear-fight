using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleCreateLeaderboardRequest
	{
		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[Preserve]
		[DataMember(Name = "operator")]
		public int Operator { get; set; }

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
