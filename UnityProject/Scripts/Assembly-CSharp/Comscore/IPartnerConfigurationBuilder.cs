namespace Comscore
{
	internal interface IPartnerConfigurationBuilder<B, P> : IClientConfigurationBuilder<B, P> where B : IPartnerConfigurationBuilder<B, P> where P : IPartnerConfiguration
	{
		B PartnerId(string publisherId);

		B ExternalClientId(string externalClientId);
	}
}
