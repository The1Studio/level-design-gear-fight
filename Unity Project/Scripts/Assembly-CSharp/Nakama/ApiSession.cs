using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiSession
	{
		[Preserve]
		[DataMember(Name = "created")]
		public bool Created { get; set; }

		[Preserve]
		[DataMember(Name = "refresh_token")]
		public string RefreshToken { get; set; }

		[DataMember(Name = "token")]
		[Preserve]
		public string Token { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
