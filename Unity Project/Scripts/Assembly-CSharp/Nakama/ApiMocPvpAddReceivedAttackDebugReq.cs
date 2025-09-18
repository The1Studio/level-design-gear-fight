using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpAddReceivedAttackDebugReq
	{
		[DataMember(Name = "associated_attack_id")]
		[Preserve]
		public string AssociatedAttackId { get; set; }

		[DataMember(Name = "attacker_user_id")]
		[Preserve]
		public string AttackerUserId { get; set; }

		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "emoji")]
		[Preserve]
		public int Emoji { get; set; }

		[Preserve]
		[DataMember(Name = "notify")]
		public bool Notify { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public ApiMocPvpAttackResult Result { get; set; }

		[Preserve]
		[DataMember(Name = "stolen_bricks")]
		public int StolenBricks { get; set; }

		[Preserve]
		[DataMember(Name = "troop_data")]
		public ApiMocPvpTroopData TroopData { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
