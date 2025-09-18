using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocAchievement
	{
		[DataMember(Name = "id")]
		[Preserve]
		public int Id { get; set; }

		[Preserve]
		[DataMember(Name = "unlock_epoch_secs")]
		public int UnlockEpochSecs { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
