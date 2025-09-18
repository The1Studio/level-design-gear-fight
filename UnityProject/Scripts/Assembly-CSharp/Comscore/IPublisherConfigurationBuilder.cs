namespace Comscore
{
	internal interface IPublisherConfigurationBuilder<B, P> : IClientConfigurationBuilder<B, P> where B : IPublisherConfigurationBuilder<B, P> where P : IPublisherConfiguration
	{
		B PublisherId(string publisherId);

		B PublisherUniqueDeviceIdListener(OnPublisherUniqueDeviceIdDelegate listener);
	}
}
