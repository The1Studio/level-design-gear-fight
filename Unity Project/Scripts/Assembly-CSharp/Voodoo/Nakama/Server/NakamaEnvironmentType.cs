using System;

namespace Voodoo.Nakama.Server
{
	[Serializable]
	public enum NakamaEnvironmentType
	{
		Local = 0,
		Dev = 1,
		Staging = 2,
		Prod = 3
	}
}
