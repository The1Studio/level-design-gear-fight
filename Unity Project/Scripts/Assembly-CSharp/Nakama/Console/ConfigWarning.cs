using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConfigWarning
	{
		[Preserve]
		[DataMember(Name = "field")]
		public string Field { get; set; }

		[Preserve]
		[DataMember(Name = "message")]
		public string Message { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
