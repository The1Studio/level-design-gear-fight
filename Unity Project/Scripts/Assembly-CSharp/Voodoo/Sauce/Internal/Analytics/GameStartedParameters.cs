using System;
using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class GameStartedParameters
	{
		public string level;

		public int ordinal;

		public int loop;

		public string levelDefinitionID;

		public Enum progression;

		public int levelMoves;

		public int additionalMovesGranted;

		public float? numberOfObjectives;

		public Enum gameMode;

		public string seed;

		public Dictionary<string, object> eventProperties;

		public Dictionary<string, object> eventContextProperties;
	}
}
