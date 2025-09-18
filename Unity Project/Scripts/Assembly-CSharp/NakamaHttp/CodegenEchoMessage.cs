using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class CodegenEchoMessage
	{
		[DataMember(Name = "null_message")]
		[Preserve]
		public CodegenEchoSubMessage NullMessage;

		[Preserve]
		[DataMember(Name = "filled_message")]
		public CodegenEchoSubMessage FilledMessage;

		[Preserve]
		[DataMember(Name = "string_string_map")]
		public Dictionary<string, string> StringStringMap;

		[DataMember(Name = "string_int32_map")]
		[Preserve]
		public Dictionary<string, int> StringInt32Map;

		[DataMember(Name = "string_int64_map")]
		[Preserve]
		public Dictionary<string, long> StringInt64Map;

		[Preserve]
		[DataMember(Name = "string_double_map")]
		public Dictionary<string, double> StringDoubleMap;

		[Preserve]
		[DataMember(Name = "string_bool_map")]
		public Dictionary<string, bool> StringBoolMap;

		[Preserve]
		[DataMember(Name = "string_message_map")]
		public Dictionary<string, CodegenEchoSubMessage> StringMessageMap;

		[DataMember(Name = "string_enum_map")]
		[Preserve]
		public Dictionary<string, EnumValue> StringEnumMap;

		[Preserve]
		[DataMember(Name = "int32_list_empty")]
		public List<int> Int32ListEmpty;

		[Preserve]
		[DataMember(Name = "int32_list_single_item")]
		public List<int> Int32ListSingleItem;

		[Preserve]
		[DataMember(Name = "int32_list_multi_item")]
		public List<int> Int32ListMultiItem;

		[DataMember(Name = "int64_list_empty")]
		[Preserve]
		public List<long> Int64ListEmpty;

		[DataMember(Name = "int64_list_single_item")]
		[Preserve]
		public List<long> Int64ListSingleItem;

		[Preserve]
		[DataMember(Name = "int64_list_multi_item")]
		public List<long> Int64ListMultiItem;

		[Preserve]
		[DataMember(Name = "bool_list_empty")]
		public List<bool> BoolListEmpty;

		[Preserve]
		[DataMember(Name = "bool_list_single_item")]
		public List<bool> BoolListSingleItem;

		[DataMember(Name = "bool_list_multi_item")]
		[Preserve]
		public List<bool> BoolListMultiItem;

		[DataMember(Name = "double_list_empty")]
		[Preserve]
		public List<double> DoubleListEmpty;

		[DataMember(Name = "double_list_single_item")]
		[Preserve]
		public List<double> DoubleListSingleItem;

		[Preserve]
		[DataMember(Name = "double_list_multi_item")]
		public List<double> DoubleListMultiItem;

		[DataMember(Name = "message_list_empty")]
		[Preserve]
		public List<CodegenEchoSubMessage> MessageListEmpty;

		[Preserve]
		[DataMember(Name = "message_list_single_item")]
		public List<CodegenEchoSubMessage> MessageListSingleItem;

		[DataMember(Name = "message_list_multi_item")]
		[Preserve]
		public List<CodegenEchoSubMessage> MessageListMultiItem;

		[DataMember(Name = "string_list_empty")]
		[Preserve]
		public List<string> StringListEmpty;

		[DataMember(Name = "string_list_single_item")]
		[Preserve]
		public List<string> StringListSingleItem;

		[DataMember(Name = "string_list_multi_item")]
		[Preserve]
		public List<string> StringListMultiItem;

		[Preserve]
		[DataMember(Name = "enum_list_empty")]
		public List<EnumValue> EnumListEmpty;

		[DataMember(Name = "enum_list_single_item")]
		[Preserve]
		public List<EnumValue> EnumListSingleItem;

		[Preserve]
		[DataMember(Name = "enum_list_multi_item")]
		public List<EnumValue> EnumListMultiItem;

		[DataMember(Name = "null_string")]
		[Preserve]
		public string NullString;

		[Preserve]
		[DataMember(Name = "null_int32")]
		public int NullInt32;

		[Preserve]
		[DataMember(Name = "null_int64")]
		public long NullInt64;

		[DataMember(Name = "null_bool")]
		[Preserve]
		public bool NullBool;

		[Preserve]
		[DataMember(Name = "null_double")]
		public double NullDouble;

		[DataMember(Name = "empty_string")]
		[Preserve]
		public string EmptyString;

		[DataMember(Name = "filled_string")]
		[Preserve]
		public string FilledString;

		[DataMember(Name = "filled_int32")]
		[Preserve]
		public int FilledInt32;

		[DataMember(Name = "filled_int64")]
		[Preserve]
		public long FilledInt64;

		[DataMember(Name = "filled_bool")]
		[Preserve]
		public bool FilledBool;

		[Preserve]
		[DataMember(Name = "filled_double")]
		public double FilledDouble;

		[DataMember(Name = "filled_enum")]
		[Preserve]
		public EnumValue FilledEnum;

		public CodegenEchoMessage()
		{
		}

		public CodegenEchoMessage(CodegenEchoSubMessage nullMessageParam, CodegenEchoSubMessage filledMessageParam, Dictionary<string, string> stringStringMapParam, Dictionary<string, int> stringInt32MapParam, Dictionary<string, long> stringInt64MapParam, Dictionary<string, double> stringDoubleMapParam, Dictionary<string, bool> stringBoolMapParam, Dictionary<string, CodegenEchoSubMessage> stringMessageMapParam, Dictionary<string, EnumValue> stringEnumMapParam, List<int> int32ListEmptyParam, List<int> int32ListSingleItemParam, List<int> int32ListMultiItemParam, List<long> int64ListEmptyParam, List<long> int64ListSingleItemParam, List<long> int64ListMultiItemParam, List<bool> boolListEmptyParam, List<bool> boolListSingleItemParam, List<bool> boolListMultiItemParam, List<double> doubleListEmptyParam, List<double> doubleListSingleItemParam, List<double> doubleListMultiItemParam, List<CodegenEchoSubMessage> messageListEmptyParam, List<CodegenEchoSubMessage> messageListSingleItemParam, List<CodegenEchoSubMessage> messageListMultiItemParam, List<string> stringListEmptyParam, List<string> stringListSingleItemParam, List<string> stringListMultiItemParam, List<EnumValue> enumListEmptyParam, List<EnumValue> enumListSingleItemParam, List<EnumValue> enumListMultiItemParam, string nullStringParam, int nullInt32Param, long nullInt64Param, bool nullBoolParam, double nullDoubleParam, string emptyStringParam, string filledStringParam, int filledInt32Param, long filledInt64Param, bool filledBoolParam, double filledDoubleParam, EnumValue filledEnumParam)
		{
		}
	}
}
