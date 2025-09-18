using System;

namespace Voodoo.Sauce.Internal.CrossPromo.Configuration
{
	[Serializable]
	internal class CrossPromoConfiguration
	{
		public bool enabled;

		public int sessionsCountBeforeShowing;

		public int sessionsCountBetweenShowing;

		public int gamesCountBeforeShowing;

		public int gamesCountBetweenShowing;

		public int impressionsCountBeforeHiding;

		public string gamesToShow;

		public string waterfallId;

		public override string ToString()
		{
			return null;
		}
	}
}
