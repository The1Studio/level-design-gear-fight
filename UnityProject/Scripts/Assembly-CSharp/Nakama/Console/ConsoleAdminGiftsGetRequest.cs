using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAdminGiftsGetRequest
	{
		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
