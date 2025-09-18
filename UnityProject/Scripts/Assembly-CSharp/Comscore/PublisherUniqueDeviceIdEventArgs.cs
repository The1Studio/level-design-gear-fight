using System;

namespace Comscore
{
	public class PublisherUniqueDeviceIdEventArgs : EventArgs
	{
		public string PublisherId { get; }

		public string PublisherUniqueDeviceId { get; }

		public PublisherUniqueDeviceIdEventArgs(string publisherId, string pudid)
		{
		}
	}
}
