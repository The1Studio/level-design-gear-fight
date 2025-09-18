using System;
using Core.UI;
using GearGame.Control;
using ScriptableTemplates;
using UnityEngine;

namespace GearGame.UI
{
	public class BossBattleCanvasController : Core.UI.Screen
	{
		[Serializable]
		public class BossLevel
		{
			[SerializeField]
			private string _displayNameLocKey;

			[field: SerializeField]
			public Sprite DisplaySprite { get; private set; }

			[field: SerializeField]
			public int DifficultyValue { get; private set; }

			[field: SerializeField]
			public ChapterSettings ChapterSettings { get; private set; }

			[field: SerializeField]
			public ScriptableTroop UnlockCharacter { get; private set; }

			[field: SerializeField]
			public int LockedDurationSeconds { get; private set; }

			public string GetLocalizedDisplayName()
			{
				return null;
			}
		}

		[SerializeField]
		private BossLevel[] allBossLevels;

		[SerializeField]
		private BossBattleDisplayController bossBattleDisplay;

		[SerializeField]
		private ChaptersProgressionSettings bossChapterProgressionSettings;

		[SerializeField]
		private GameObject rightArrowRoot;

		[SerializeField]
		private GameObject leftArrowRoot;

		private int displayOn;

		private void Start()
		{
		}

		public bool HasLevelAvailable()
		{
			return false;
		}

		public void OnRightPressed()
		{
		}

		public void OnLeftPressed()
		{
		}

		private void SetBossDisplay(int displayIndex)
		{
		}

		public void SetOnBossBattleStartedCallback(Action callback)
		{
		}
	}
}
