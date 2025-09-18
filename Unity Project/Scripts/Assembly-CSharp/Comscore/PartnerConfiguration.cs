using UnityEngine;

namespace Comscore
{
	public class PartnerConfiguration : ClientConfiguration, IPartnerConfiguration, IClientConfiguration
	{
		public new class Builder : Builder<Builder, PartnerConfiguration>, IPartnerConfigurationBuilder<Builder, PartnerConfiguration>, IClientConfigurationBuilder<Builder, PartnerConfiguration>
		{
			private const string className = "com.comscore.PartnerConfiguration$Builder";

			public Builder()
				: base((AndroidJavaObject)null)
			{
			}

			protected override Builder Self()
			{
				return null;
			}

			public Builder PartnerId(string partnerId)
			{
				return null;
			}

			public Builder ExternalClientId(string externalClientId)
			{
				return null;
			}

			public override PartnerConfiguration Build()
			{
				return null;
			}
		}

		internal PartnerConfiguration(AndroidJavaObject javaInstance)
			: base(null)
		{
		}
	}
}
