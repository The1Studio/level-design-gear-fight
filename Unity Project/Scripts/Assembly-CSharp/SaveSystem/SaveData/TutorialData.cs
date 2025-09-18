using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class TutorialData : ServerBaseData
	{
		public Dictionary<string, bool> TutorialSteps;

		public bool SkipTicketTutorialCompleted;

		public void ValidateTutorialStep(string id)
		{
		}

		public bool IsTutorialStepPassed(string id)
		{
			return false;
		}
	}
}
