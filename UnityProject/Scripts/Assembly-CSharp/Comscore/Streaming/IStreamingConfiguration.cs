using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IStreamingConfiguration<StrPubConf> where StrPubConf : IStreamingPublisherConfiguration
	{
		StrPubConf GetStreamingPublisherConfiguration(string publisherId);

		void SetLabel(string name, string value);

		void AddLabels(Dictionary<string, string> labels);

		void RemoveLabel(string name);

		void RemoveAllLabels();
	}
}
