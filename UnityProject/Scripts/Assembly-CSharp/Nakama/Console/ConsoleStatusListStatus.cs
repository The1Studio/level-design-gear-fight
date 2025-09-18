using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleStatusListStatus
	{
		[Preserve]
		[DataMember(Name = "avg_input_kbs")]
		public double AvgInputKbs { get; set; }

		[DataMember(Name = "avg_latency_ms")]
		[Preserve]
		public double AvgLatencyMs { get; set; }

		[DataMember(Name = "avg_output_kbs")]
		[Preserve]
		public double AvgOutputKbs { get; set; }

		[DataMember(Name = "avg_rate_sec")]
		[Preserve]
		public double AvgRateSec { get; set; }

		[DataMember(Name = "goroutine_count")]
		[Preserve]
		public int GoroutineCount { get; set; }

		[Preserve]
		[DataMember(Name = "health")]
		public int Health { get; set; }

		[Preserve]
		[DataMember(Name = "match_count")]
		public int MatchCount { get; set; }

		[Preserve]
		[DataMember(Name = "name")]
		public string Name { get; set; }

		[DataMember(Name = "presence_count")]
		[Preserve]
		public int PresenceCount { get; set; }

		[DataMember(Name = "session_count")]
		[Preserve]
		public int SessionCount { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
