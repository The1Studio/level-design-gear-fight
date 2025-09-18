using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpReceivedAttack
	{
		[DataMember(Name = "associated_attack_id")]
		[Preserve]
		public string AssociatedAttackId { get; set; }

		[DataMember(Name = "attacker_player_data")]
		[Preserve]
		public ApiMocPlayerData AttackerPlayerData { get; set; }

		[Preserve]
		[DataMember(Name = "created_at_unix")]
		public int CreatedAtUnix { get; set; }

		[Preserve]
		[DataMember(Name = "emoji")]
		public int Emoji { get; set; }

		[Preserve]
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public ApiMocPvpAttackResult Result { get; set; }

		[DataMember(Name = "seconds_until_expiry")]
		[Preserve]
		public int SecondsUntilExpiry { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public ApiMocPvpReceivedAttackStatus Status { get; set; }

		[DataMember(Name = "stolen_bricks")]
		[Preserve]
		public int StolenBricks { get; set; }

		[Preserve]
		[DataMember(Name = "troop_data")]
		public ApiMocPvpTroopData TroopData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
