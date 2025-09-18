using System;
using Newtonsoft.Json;

namespace Voodoo.Nakama.Server
{
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)]
	public class NakamaLoginState
	{
		[JsonProperty]
		private string _deviceID;

		public string DeviceID
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void Init()
		{
		}

		private void Save()
		{
		}
	}
}
