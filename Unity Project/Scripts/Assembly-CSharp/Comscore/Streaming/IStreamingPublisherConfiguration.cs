using System.Collections.Generic;

namespace Comscore.Streaming
{
	internal interface IStreamingPublisherConfiguration
	{
		void SetLabel(string name, string value);

		void RemoveLabel(string name);

		void AddLabels(Dictionary<string, string> labels);

		void RemoveAllLabels();
	}
}
