using System.Collections.Generic;
using Core.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class MiniBossCanvasController : Popup
	{
		[SerializeField]
		private Transform rewardSpawnTransform;

		[SerializeField]
		private Image headImage;

		[SerializeField]
		private ScriptableMiniBossRewardsData miniBossRewardData;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private GameObject claimRoot;

		[SerializeField]
		private AudioSourceVariable claimAudio;

		[SerializeField]
		private AudioSourceVariable cardPlayAudio;

		[SerializeField]
		private TextMeshProUGUI titleText;

		private List<MiniBossRewardButton> allRewardAnimators;

		private ScriptableMiniBossRewardsData.Reward[] rewards;

		protected void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Initialize(Sprite headSprite, bool isChest)
		{
		}

		public void OnEntranceAnimationCompleted()
		{
		}

		public void OnExitAnimationCompleted()
		{
		}

		public void OnClaimPressed()
		{
		}
	}
}
