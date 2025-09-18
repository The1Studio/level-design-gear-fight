using System.Collections.Generic;
using UnityEngine;

namespace Comscore.Streaming
{
	public class StreamingPublisherConfiguration : IStreamingPublisherConfiguration
	{
		private AndroidJavaObject JavaInstance { get; }

		internal StreamingPublisherConfiguration(AndroidJavaObject javaInstance)
		{
		}

		public void AddLabels(Dictionary<string, string> labels)
		{
		}

		public void RemoveAllLabels()
		{
		}

		public void RemoveLabel(string name)
		{
		}

		public void SetLabel(string name, string value)
		{
		}
	}
}
