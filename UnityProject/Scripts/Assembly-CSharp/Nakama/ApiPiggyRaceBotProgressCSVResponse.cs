using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceBotProgressCSVResponse
	{
		[DataMember(Name = "file_url")]
		[Preserve]
		public string FileUrl { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
