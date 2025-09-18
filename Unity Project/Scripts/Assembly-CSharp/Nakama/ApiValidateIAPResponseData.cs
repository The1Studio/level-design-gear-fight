using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiValidateIAPResponseData
	{
		[Preserve]
		[DataMember(Name = "validated")]
		public bool Validated { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
