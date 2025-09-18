using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsPointConfig
	{
		[DataMember(Name = "base_loss_points")]
		[Preserve]
		public int BaseLossPoints { get; set; }

		[DataMember(Name = "base_win_points")]
		[Preserve]
		public int BaseWinPoints { get; set; }

		[DataMember(Name = "loss_tier_multiplier")]
		[Preserve]
		public int LossTierMultiplier { get; set; }

		[DataMember(Name = "win_tier_multiplier")]
		[Preserve]
		public int WinTierMultiplier { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
