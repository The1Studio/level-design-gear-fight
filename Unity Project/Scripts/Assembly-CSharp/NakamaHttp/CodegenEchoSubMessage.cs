using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class CodegenEchoSubMessage
	{
		[Preserve]
		[DataMember(Name = "string_int64_map")]
		public Dictionary<string, long> StringInt64Map;

		[Preserve]
		[DataMember(Name = "repeated_string")]
		public List<string> RepeatedString;

		[DataMember(Name = "int32_field")]
		[Preserve]
		public int Int32Field;

		[DataMember(Name = "int64_field")]
		[Preserve]
		public long Int64Field;

		public CodegenEchoSubMessage()
		{
		}

		public CodegenEchoSubMessage(Dictionary<string, long> stringInt64MapParam, List<string> repeatedStringParam, int int32FieldParam, long int64FieldParam)
		{
		}
	}
}
