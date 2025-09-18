using System.Collections.Generic;
using UnityEngine;

namespace Comscore
{
	public class EventInfo : IEventInfo
	{
		private readonly AndroidJavaObject javaInstance;

		private const string className = "com.comscore.EventInfo";

		public void AddLabels(Dictionary<string, string> labels)
		{
		}

		public void SetLabel(string name, string value)
		{
		}

		public void AddPublisherLabels(string publisherId, Dictionary<string, string> labels)
		{
		}

		public void SetPublisherLabel(string publisherId, string name, string value)
		{
		}

		public void AddIncludedPublisher(string publisherId)
		{
		}

		internal AndroidJavaObject GetJavaInstance()
		{
			return null;
		}
	}
}
