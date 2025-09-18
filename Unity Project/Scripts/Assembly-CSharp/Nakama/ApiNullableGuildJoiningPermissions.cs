using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiNullableGuildJoiningPermissions
	{
		[DataMember(Name = "value")]
		[Preserve]
		public ApiGuildJoiningPermissions Value { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
