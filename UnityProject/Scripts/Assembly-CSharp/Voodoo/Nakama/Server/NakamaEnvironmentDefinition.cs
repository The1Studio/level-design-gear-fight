using System;

namespace Voodoo.Nakama.Server
{
	[Serializable]
	public class NakamaEnvironmentDefinition
	{
		public NakamaEnvironmentType type;

		public string scheme;

		public string host;

		public int port;

		public string serverKey;

		public override string ToString()
		{
			return null;
		}
	}
}
