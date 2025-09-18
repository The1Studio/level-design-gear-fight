using System.Collections.Generic;

namespace Comscore
{
	internal interface IClientConfigurationBuilder<B, P> where B : IClientConfigurationBuilder<B, P> where P : IClientConfiguration
	{
		P Build();

		B KeepAliveMeasurement(bool enabled);

		B PersistentLabels(Dictionary<string, string> labels);

		B StartLabels(Dictionary<string, string> labels);

		B SecureTransmission(bool enabled);

		B HttpRedirectCaching(bool enabled);
	}
}
