using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsDuelResult
	{
		[DataMember(Name = "duel_id")]
		[Preserve]
		public string DuelId { get; set; }

		[DataMember(Name = "duel_tier")]
		[Preserve]
		public int DuelTier { get; set; }

		[DataMember(Name = "event_id")]
		[Preserve]
		public string EventId { get; set; }

		[Preserve]
		[DataMember(Name = "points")]
		public int Points { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public bool Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
