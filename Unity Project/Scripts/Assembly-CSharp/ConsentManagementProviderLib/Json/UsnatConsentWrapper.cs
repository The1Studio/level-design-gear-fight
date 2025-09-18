using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsentManagementProviderLib.Json
{
	internal class UsnatConsentWrapper
	{
		public string? uuid;

		public ConsentStatusWrapper consentStatus;

		public bool applies;

		public List<ConsentStringWrapper> consentStrings;

		public UserConsentsWrapper userConsents;

		[JsonIgnore]
		public List<ConsentableWrapper> vendors => null;

		[JsonIgnore]
		public List<ConsentableWrapper> categories => null;
	}
}
