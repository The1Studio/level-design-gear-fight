using Core.UI;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class MiniBossSpottedCanvasController : Popup
	{
		[SerializeField]
		private Image headImage;

		[SerializeField]
		private MMF_Player feedbackPlayer;

		protected void Start()
		{
		}

		public void PlayFeedback()
		{
		}

		public void Initialize(Sprite s)
		{
		}

		protected override void OnClose()
		{
		}
	}
}
