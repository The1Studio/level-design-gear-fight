using Core.UI;
using ScriptableTemplates;
using TMPro;
using UnityEngine;

namespace GearGame.UI
{
	public class ZoneUnlockedDisplayController : Popup
	{
		[SerializeField]
		private TextMeshProUGUI textForChapterName;

		[SerializeField]
		private TextMeshProUGUI textForDescription;

		[SerializeField]
		private Animator cameraAnimator;

		public string UniqueID { get; set; }

		public static bool Validate(string id)
		{
			return false;
		}

		public void Initialize(ChapterSettings chapterSettings)
		{
		}

		protected override void OnClose()
		{
		}

		public void OnAnimationCompleted()
		{
		}
	}
}
