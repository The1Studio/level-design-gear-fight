using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidateIAPResponse
	{
		[Preserve]
		[DataMember(Name = "data")]
		public ApiValidateIAPResponseData Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
