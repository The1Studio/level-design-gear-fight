using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpTroopData
	{
		[DataMember(Name = "cannon")]
		[Preserve]
		public ApiMocPvpUnit Cannon { get; set; }

		[DataMember(Name = "champion")]
		[Preserve]
		public ApiMocPvpUnit Champion { get; set; }

		[DataMember(Name = "mob")]
		[Preserve]
		public ApiMocPvpUnit Mob { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
