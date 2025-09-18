using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceScheduleRoundConfiguration
	{
		[Preserve]
		[DataMember(Name = "auto_fill_with_bots")]
		public bool AutoFillWithBots { get; set; }

		[Preserve]
		[DataMember(Name = "bot_cooldown_seconds")]
		public string BotCooldownSeconds { get; set; }

		[DataMember(Name = "bot_max_points_per_hour")]
		[Preserve]
		public string BotMaxPointsPerHour { get; set; }

		[Preserve]
		[DataMember(Name = "bot_min_points_per_hour")]
		public string BotMinPointsPerHour { get; set; }

		[Preserve]
		[DataMember(Name = "extra_bots")]
		public int ExtraBots { get; set; }

		[Preserve]
		[DataMember(Name = "group_creation_enabled")]
		public bool GroupCreationEnabled { get; set; }

		[Preserve]
		[DataMember(Name = "manual_join_required")]
		public bool ManualJoinRequired { get; set; }

		[Preserve]
		[DataMember(Name = "max_win_streak")]
		public string MaxWinStreak { get; set; }

		[Preserve]
		[DataMember(Name = "min_level")]
		public string MinLevel { get; set; }

		[Preserve]
		[DataMember(Name = "number_of_streak_winners")]
		public string NumberOfStreakWinners { get; set; }

		[DataMember(Name = "position_to_reward")]
		[Preserve]
		public string PositionToReward { get; set; }

		[DataMember(Name = "race_duration")]
		[Preserve]
		public string RaceDuration { get; set; }

		[Preserve]
		[DataMember(Name = "return_round_data_when_not_joined")]
		public bool ReturnRoundDataWhenNotJoined { get; set; }

		[DataMember(Name = "seconds_before_auto_fill_with_bots")]
		[Preserve]
		public int SecondsBeforeAutoFillWithBots { get; set; }

		[DataMember(Name = "streak_rewards")]
		[Preserve]
		public string StreakRewards { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
