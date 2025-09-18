using GearGame.Control;
using GearGame.Gameplay;
using Refactor.Scripts;
using UI.Refactor.Popups;
using UnityEngine;

namespace ScriptableTemplates
{
	[CreateAssetMenu(menuName = "GearFight/Game Data/Chapter")]
	public class ChapterSettings : ScriptableObject
	{
		[Header("General Settings")]
		public string ID;

		public string DisplayNameLocalizationKey;

		public bool ShowWorldUnlock;

		public EnvironmentThemeView EnvironmentTheme;

		public AudioClip MainMusic;

		public Sprite SlopeSprite;

		[Header("OneTimeUnlockSequence")]
		public string[] LocalizationStrings;

		[Header("Show Every Time")]
		public BossLevelPopup ShowPopupEveryLevelStart;

		[Header("Chapter Levels")]
		public ScriptableLevel[] Levels;

		[Header("Chapter Levels")]
		public ScriptableTroop[] AllMiniBosses;

		public ScriptableUnlockableUpgradable[] ChapterSpecificUnlocks;
	}
}
