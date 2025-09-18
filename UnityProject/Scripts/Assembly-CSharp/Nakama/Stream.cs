using System.Runtime.Serialization;

namespace Nakama
{
	public class Stream : IStream
	{
		[DataMember(Name = "descriptor")]
		[Preserve]
		public string Descriptor { get; set; }

		[DataMember(Name = "label")]
		[Preserve]
		public string Label { get; set; }

		[DataMember(Name = "mode")]
		[Preserve]
		public int Mode { get; set; }

		[DataMember(Name = "subject")]
		[Preserve]
		public string Subject { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
