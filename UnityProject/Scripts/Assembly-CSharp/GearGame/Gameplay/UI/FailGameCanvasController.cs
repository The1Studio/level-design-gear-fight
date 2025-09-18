using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI
{
	public class FailGameCanvasController : EndGameCanvasController
	{
		[SerializeField]
		private TextMeshProUGUI waveText;

		[SerializeField]
		private AnimationCurve bonusLevelCurveOverride;

		[SerializeField]
		private GameObject regularCollectObject;

		[SerializeField]
		private GameObject revivePremiumObject;

		[SerializeField]
		private GameObject reviveRegularObject;

		[SerializeField]
		private int premiumRevivePayout;

		[SerializeField]
		private ScriptableGear premiumReviveGear;

		private bool isPremiumRevive;

		protected void OnEnable()
		{
		}

		public void OnRevive()
		{
		}

		public override void OnCollectPressed()
		{
		}

		protected override float GetProgressPercent()
		{
			return 0f;
		}
	}
}
