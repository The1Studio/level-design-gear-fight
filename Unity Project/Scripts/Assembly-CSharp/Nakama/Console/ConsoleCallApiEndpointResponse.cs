using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleCallApiEndpointResponse
	{
		[DataMember(Name = "body")]
		[Preserve]
		public string Body { get; set; }

		[Preserve]
		[DataMember(Name = "error_message")]
		public string ErrorMessage { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
