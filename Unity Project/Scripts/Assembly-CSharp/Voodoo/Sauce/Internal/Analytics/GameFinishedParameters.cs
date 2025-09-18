using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class GameFinishedParameters
	{
		public int gameDuration;

		public string level;

		public bool status;

		public float score;

		public string levelDefinitionID;

		public Enum gameEndReason;

		public int? nbStars;

		public int? movesUsed;

		public int? movesLeft;

		public int? objectivesLeft;

		public float softCurrencyUsed;

		public float hardCurrencyUsed;

		public int egpsUsed;

		public int egpsRvUsed;

		public int? levelMoves;

		public int? additionalMovesGranted;

		public int? egpMoves;

		public int? nbInGameBoostersUsed;

		public Dictionary<string, object> eventProperties;

		public Dictionary<string, object> eventContextProperties;
	}
}
