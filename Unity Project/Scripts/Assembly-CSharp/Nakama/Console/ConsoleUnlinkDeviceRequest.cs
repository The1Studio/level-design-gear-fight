using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleUnlinkDeviceRequest
	{
		[DataMember(Name = "device_id")]
		[Preserve]
		public string DeviceId { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
