using System;

namespace Comscore
{
	public class CrossPublisherUniqueDeviceIdChangedEventArgs : EventArgs
	{
		private readonly string crossPublisherUniqueId;

		public string CrossPublisherUniqueId => null;

		public CrossPublisherUniqueDeviceIdChangedEventArgs(string crossPublisherUniqueId)
		{
		}
	}
}
