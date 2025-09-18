using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class RewardItem
	{
		[DataMember(Name = "identifier")]
		[Preserve]
		public string Identifier;

		[DataMember(Name = "description")]
		[Preserve]
		public string Description;

		[Preserve]
		[DataMember(Name = "version")]
		public string Version;

		public RewardItem()
		{
		}

		public RewardItem(string identifierParam, string descriptionParam, string versionParam)
		{
		}
	}
}
