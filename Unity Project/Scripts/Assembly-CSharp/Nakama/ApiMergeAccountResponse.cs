using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMergeAccountResponse
	{
		[DataMember(Name = "account")]
		[Preserve]
		public ApiAccount Account { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
