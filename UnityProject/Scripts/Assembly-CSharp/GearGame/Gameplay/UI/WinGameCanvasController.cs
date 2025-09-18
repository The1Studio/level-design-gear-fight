using UnityEngine;

namespace GearGame.Gameplay.UI
{
	public class WinGameCanvasController : EndGameCanvasController
	{
		[SerializeField]
		private GameObject rewardedADParent;

		[SerializeField]
		private GameObject notRewardedADParent;

		protected void OnEnable()
		{
		}

		protected override float GetProgressPercent()
		{
			return 0f;
		}

		public void OnMultiplyCompleted()
		{
		}
	}
}
