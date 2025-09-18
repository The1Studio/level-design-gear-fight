using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voodoo.Live.Utils
{
	[CreateAssetMenu(fileName = "SpriteDictionary", menuName = "VoodooLive/Sprite Dictionary")]
	public class SpriteDictionarySO : ScriptableObject
	{
		[Serializable]
		public class SpriteEntry
		{
			public Sprite sprite;

			public string id;
		}

		private const string TAG = "VOODOOLIVE_SPRITES";

		[Header("Sprite Dictionary")]
		public List<SpriteEntry> spriteEntries;

		public Sprite GetSpriteById(string id)
		{
			return null;
		}

		private Sprite GetDefaultSprite(string id)
		{
			return null;
		}
	}
}
