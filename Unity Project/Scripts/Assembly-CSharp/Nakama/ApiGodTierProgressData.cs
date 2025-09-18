using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierProgressData
	{
		[DataMember(Name = "participant_data")]
		[Preserve]
		public ApiGodTierParticipantData ParticipantData { get; set; }

		[Preserve]
		[DataMember(Name = "top_data")]
		public ApiGodTierTopData TopData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
