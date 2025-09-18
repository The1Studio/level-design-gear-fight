using System;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class GameVariables : ServerBaseData
	{
		public int Level;

		public int MaxScene;

		public string FirstBuild;

		public bool FirstTutorial;

		public bool TutorialSkip;
	}
}
