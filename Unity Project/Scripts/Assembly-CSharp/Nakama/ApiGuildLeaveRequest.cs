using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildLeaveRequest
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
