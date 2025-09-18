using System.Collections.Generic;
using UnityEngine;

namespace Comscore
{
	public abstract class ClientConfiguration : IClientConfiguration
	{
		public abstract class Builder<B, P> : IClientConfigurationBuilder<B, P> where B : Builder<B, P> where P : ClientConfiguration
		{
			protected readonly AndroidJavaObject builderJavaInstance;

			internal Builder(AndroidJavaObject androidJavaObject)
			{
			}

			public abstract P Build();

			protected abstract B Self();

			public B HttpRedirectCaching(bool enabled)
			{
				return null;
			}

			public B KeepAliveMeasurement(bool enabled)
			{
				return null;
			}

			public B PersistentLabels(Dictionary<string, string> labels)
			{
				return null;
			}

			public B SecureTransmission(bool enabled)
			{
				return null;
			}

			public B StartLabels(Dictionary<string, string> labels)
			{
				return null;
			}
		}

		protected readonly AndroidJavaObject javaInstance;

		protected ClientConfiguration(AndroidJavaObject javaInstance)
		{
		}

		internal AndroidJavaObject GetJavaInstance()
		{
			return null;
		}
	}
}
