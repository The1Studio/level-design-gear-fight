using System;
using Core.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class BossBattleDisplayController : MonoBehaviour
	{
		[SerializeField]
		private Image displayImage;

		[SerializeField]
		private Image characterUnlockImage;

		[SerializeField]
		private TextMeshProUGUI displayText;

		[SerializeField]
		private TextMeshProUGUI rewardBlueCoinsText;

		[SerializeField]
		private TextMeshProUGUI rewardsGreenCoinsText;

		[SerializeField]
		private TextMeshProUGUI timerDisplay;

		[SerializeField]
		private AudioSource lockedPlaySource;

		[SerializeField]
		private Button playButton;

		[SerializeField]
		private GameObject lockedRoot;

		private bool isLocked;

		private Timer timer;

		private BossBattleCanvasController.BossLevel bossLevel;

		private readonly int activeHash;

		private Action _onBossBattleStartedCallback;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetDisplay(BossBattleCanvasController.BossLevel bossLevel)
		{
		}

		private void TimerChanged(Timer timeSpan)
		{
		}

		public void OnPlayPressed()
		{
		}

		private void SetLockedStatus(bool status)
		{
		}

		public void SetOnBossBattleStartedCallback(Action callback)
		{
		}
	}
}
