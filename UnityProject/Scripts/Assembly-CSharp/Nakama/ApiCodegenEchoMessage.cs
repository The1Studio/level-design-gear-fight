using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCodegenEchoMessage
	{
		[DataMember(Name = "bool_list_empty")]
		[Preserve]
		public List<bool> BoolListEmpty { get; set; }

		[DataMember(Name = "bool_list_multi_item")]
		[Preserve]
		public List<bool> BoolListMultiItem { get; set; }

		[DataMember(Name = "bool_list_single_item")]
		[Preserve]
		public List<bool> BoolListSingleItem { get; set; }

		[DataMember(Name = "double_list_empty")]
		[Preserve]
		public List<double> DoubleListEmpty { get; set; }

		[Preserve]
		[DataMember(Name = "double_list_multi_item")]
		public List<double> DoubleListMultiItem { get; set; }

		[Preserve]
		[DataMember(Name = "double_list_single_item")]
		public List<double> DoubleListSingleItem { get; set; }

		[DataMember(Name = "empty_string")]
		[Preserve]
		public string EmptyString { get; set; }

		[DataMember(Name = "enum_list_empty")]
		[Preserve]
		public List<ApiEnumValue> EnumListEmpty { get; set; }

		[DataMember(Name = "enum_list_multi_item")]
		[Preserve]
		public List<ApiEnumValue> EnumListMultiItem { get; set; }

		[DataMember(Name = "enum_list_single_item")]
		[Preserve]
		public List<ApiEnumValue> EnumListSingleItem { get; set; }

		[DataMember(Name = "filled_bool")]
		[Preserve]
		public bool FilledBool { get; set; }

		[DataMember(Name = "filled_double")]
		[Preserve]
		public double FilledDouble { get; set; }

		[DataMember(Name = "filled_enum")]
		[Preserve]
		public ApiEnumValue FilledEnum { get; set; }

		[Preserve]
		[DataMember(Name = "filled_int32")]
		public int FilledInt32 { get; set; }

		[DataMember(Name = "filled_int64")]
		[Preserve]
		public long FilledInt64 { get; set; }

		[DataMember(Name = "filled_message")]
		[Preserve]
		public ApiCodegenEchoSubMessage FilledMessage { get; set; }

		[DataMember(Name = "filled_string")]
		[Preserve]
		public string FilledString { get; set; }

		[Preserve]
		[DataMember(Name = "int32_list_empty")]
		public List<int> Int32ListEmpty { get; set; }

		[DataMember(Name = "int32_list_multi_item")]
		[Preserve]
		public List<int> Int32ListMultiItem { get; set; }

		[DataMember(Name = "int32_list_single_item")]
		[Preserve]
		public List<int> Int32ListSingleItem { get; set; }

		[DataMember(Name = "int64_list_empty")]
		[Preserve]
		public List<long> Int64ListEmpty { get; set; }

		[DataMember(Name = "int64_list_multi_item")]
		[Preserve]
		public List<long> Int64ListMultiItem { get; set; }

		[DataMember(Name = "int64_list_single_item")]
		[Preserve]
		public List<long> Int64ListSingleItem { get; set; }

		[DataMember(Name = "message_list_empty")]
		[Preserve]
		public List<ApiCodegenEchoSubMessage> MessageListEmpty { get; set; }

		[DataMember(Name = "message_list_multi_item")]
		[Preserve]
		public List<ApiCodegenEchoSubMessage> MessageListMultiItem { get; set; }

		[DataMember(Name = "message_list_single_item")]
		[Preserve]
		public List<ApiCodegenEchoSubMessage> MessageListSingleItem { get; set; }

		[DataMember(Name = "null_bool")]
		[Preserve]
		public bool NullBool { get; set; }

		[DataMember(Name = "null_double")]
		[Preserve]
		public double NullDouble { get; set; }

		[Preserve]
		[DataMember(Name = "null_int32")]
		public int NullInt32 { get; set; }

		[DataMember(Name = "null_int64")]
		[Preserve]
		public long NullInt64 { get; set; }

		[DataMember(Name = "null_message")]
		[Preserve]
		public ApiCodegenEchoSubMessage NullMessage { get; set; }

		[Preserve]
		[DataMember(Name = "null_string")]
		public string NullString { get; set; }

		[DataMember(Name = "string_bool_map")]
		[Preserve]
		public Dictionary<string, bool> StringBoolMap { get; set; }

		[DataMember(Name = "string_double_map")]
		[Preserve]
		public Dictionary<string, double> StringDoubleMap { get; set; }

		[Preserve]
		[DataMember(Name = "string_enum_map")]
		public Dictionary<string, ApiEnumValue> StringEnumMap { get; set; }

		[DataMember(Name = "string_int32_map")]
		[Preserve]
		public Dictionary<string, int> StringInt32Map { get; set; }

		[DataMember(Name = "string_int64_map")]
		[Preserve]
		public Dictionary<string, long> StringInt64Map { get; set; }

		[Preserve]
		[DataMember(Name = "string_list_empty")]
		public List<string> StringListEmpty { get; set; }

		[Preserve]
		[DataMember(Name = "string_list_multi_item")]
		public List<string> StringListMultiItem { get; set; }

		[Preserve]
		[DataMember(Name = "string_list_single_item")]
		public List<string> StringListSingleItem { get; set; }

		[DataMember(Name = "string_message_map")]
		[Preserve]
		public Dictionary<string, ApiCodegenEchoSubMessage> StringMessageMap { get; set; }

		[Preserve]
		[DataMember(Name = "string_string_map")]
		public Dictionary<string, string> StringStringMap { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
