using System.Runtime.Serialization;

namespace Nakama
{
	public class StreamState : IStreamState
	{
		public IUserPresence Sender => null;

		[Preserve]
		[DataMember(Name = "sender")]
		public UserPresence SenderField { get; set; }

		public string State => null;

		[Preserve]
		[DataMember(Name = "data")]
		public string StateField { get; set; }

		public IStream Stream => null;

		[Preserve]
		[DataMember(Name = "stream")]
		public Stream StreamField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
