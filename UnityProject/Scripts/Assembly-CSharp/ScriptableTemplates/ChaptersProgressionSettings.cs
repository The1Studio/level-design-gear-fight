using UnityEngine;

namespace ScriptableTemplates
{
	[CreateAssetMenu(menuName = "GearFight/Game Data/Chapters Progression")]
	public class ChaptersProgressionSettings : ScriptableObject
	{
		[Header("General Settings")]
		public string ProgressionName;

		[SerializeField]
		private ChapterSettings[] chapters;

		public int TotalChapters => 0;

		public ChapterSettings[] Chapters => null;

		public bool TryGetChapterSettings(int currentChapterIndex, out ChapterSettings chapterSettings)
		{
			chapterSettings = null;
			return false;
		}

		public int GetIndexForChapter(int chapter, int level)
		{
			return 0;
		}

		public int GetWorldIndexForLevel(int level)
		{
			return 0;
		}

		public int GetLevelIndexForLevel(int level)
		{
			return 0;
		}
	}
}
