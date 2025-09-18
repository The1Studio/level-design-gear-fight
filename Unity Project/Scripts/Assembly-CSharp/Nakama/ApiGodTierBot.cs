using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierBot
	{
		[DataMember(Name = "current_score")]
		[Preserve]
		public int CurrentScore { get; set; }

		[DataMember(Name = "start_score")]
		[Preserve]
		public int StartScore { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
