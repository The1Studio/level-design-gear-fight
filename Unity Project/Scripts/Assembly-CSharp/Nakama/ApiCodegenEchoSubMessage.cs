using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCodegenEchoSubMessage
	{
		[Preserve]
		[DataMember(Name = "int32_field")]
		public int Int32Field { get; set; }

		[DataMember(Name = "int64_field")]
		[Preserve]
		public long Int64Field { get; set; }

		[Preserve]
		[DataMember(Name = "repeated_string")]
		public List<string> RepeatedString { get; set; }

		[DataMember(Name = "string_int64_map")]
		[Preserve]
		public Dictionary<string, long> StringInt64Map { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
