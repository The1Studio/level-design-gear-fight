using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Mercury.Models
{
	[Serializable]
	public struct MercuryRequestInfo
	{
		public float downloadTime;

		public bool hasTimeout;

		public string gamesPromoted;

		public string httpResponse;

		public string data;

		public MercuryWaterfall waterfall;
	}
}
