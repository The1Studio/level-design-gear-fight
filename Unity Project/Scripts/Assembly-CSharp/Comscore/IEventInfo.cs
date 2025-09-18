using System.Collections.Generic;

namespace Comscore
{
	internal interface IEventInfo
	{
		void AddLabels(Dictionary<string, string> labels);

		void SetLabel(string name, string value);

		void AddPublisherLabels(string publisherId, Dictionary<string, string> labels);

		void SetPublisherLabel(string publisherId, string name, string value);

		void AddIncludedPublisher(string publisherId);
	}
}
