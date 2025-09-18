using System;
using System.Collections.Generic;

namespace SaveSystem.SaveData
{
	[Serializable]
	public class CharacterData
	{
		public HashSet<string> CharacterBools;

		public void SetCharacterBoolToTrue(string id)
		{
		}

		public bool GetCharacterBool(string id)
		{
			return false;
		}
	}
}
