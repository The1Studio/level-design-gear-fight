using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAuthenticateEmailRequestCodeRequest
	{
		[DataMember(Name = "create")]
		[Preserve]
		public bool Create { get; set; }

		[DataMember(Name = "email")]
		[Preserve]
		public string Email { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
