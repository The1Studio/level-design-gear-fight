using Core.UI;
using TMPro;
using UnityEngine;

namespace GearGame.SingleLoad
{
	public class InfoPopupController : Popup
	{
		[SerializeField]
		private TextMeshProUGUI displayText;

		[SerializeField]
		private RectTransform rootRect;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private float offsetValue;

		public void Activate(string text, RectTransform t)
		{
		}

		public void Activate(string text, Vector2 uiPosition)
		{
		}

		public void ActivateChapterUnlock(int level, Vector3 position)
		{
		}
	}
}
