using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsentManagementProviderLib.Json
{
	internal class SpGdprConsentWrapperAndroid
	{
		public string uuid;

		public string euconsent;

		public Dictionary<string, object> tcData;

		public Dictionary<string, Dictionary<string, object>> grants;

		[JsonProperty("googleConsentMode")]
		public GCMDataWrapper gcmStatus;
	}
}
