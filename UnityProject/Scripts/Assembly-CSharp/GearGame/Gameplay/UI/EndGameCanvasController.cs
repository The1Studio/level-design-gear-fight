using Core.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public abstract class EndGameCanvasController : Popup
	{
		public const int XPPerLevel = 5;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private TextMeshProUGUI rewardBlueCoinsText;

		[SerializeField]
		private TextMeshProUGUI rewardGreenCoinsText;

		[SerializeField]
		private TextMeshProUGUI progressText;

		[SerializeField]
		private Animator characterMovementAnimator;

		protected double blueCoinReward;

		protected double greenCoinReward;

		private float targetPercent;

		private float currentProgress;

		protected abstract float GetProgressPercent();

		protected void GiveReward(bool isWin)
		{
		}

		protected virtual void Update()
		{
		}

		protected void DoubleRewards()
		{
		}

		public virtual void OnCollectPressed()
		{
		}
	}
}
