using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class MocAchievement
	{
		[DataMember(Name = "id")]
		[Preserve]
		public int Id;

		[DataMember(Name = "unlock_epoch_secs")]
		[Preserve]
		public int UnlockEpochSecs;

		public MocAchievement()
		{
		}

		public MocAchievement(int idParam, int unlockEpochSecsParam)
		{
		}
	}
}
