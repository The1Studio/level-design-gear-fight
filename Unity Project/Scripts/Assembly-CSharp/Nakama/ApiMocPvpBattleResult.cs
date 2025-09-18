using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpBattleResult
	{
		[DataMember(Name = "associated_attack_id")]
		[Preserve]
		public string AssociatedAttackId { get; set; }

		[DataMember(Name = "attack_id")]
		[Preserve]
		public string AttackId { get; set; }

		[DataMember(Name = "emoji")]
		[Preserve]
		public int Emoji { get; set; }

		[DataMember(Name = "fallback_flow")]
		[Preserve]
		public bool FallbackFlow { get; set; }

		[DataMember(Name = "opponent_id")]
		[Preserve]
		public string OpponentId { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public ApiMocPvpAttackResult Result { get; set; }

		[DataMember(Name = "stolen_bricks")]
		[Preserve]
		public int StolenBricks { get; set; }

		[Preserve]
		[DataMember(Name = "troops")]
		public ApiMocPvpTroopData Troops { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
