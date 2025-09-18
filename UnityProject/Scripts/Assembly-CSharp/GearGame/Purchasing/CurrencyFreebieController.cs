using System.Collections.Generic;
using Core.Timers;
using GearGame.Gameplay;
using TMPro;
using UnityEngine;

namespace GearGame.Purchasing
{
	public class CurrencyFreebieController : MonoBehaviour
	{
		public enum FreebieType
		{
			BlueCoin = 0,
			GreenCoin = 1,
			Diamond = 2
		}

		[SerializeField]
		private TextMeshProUGUI displayRewardValueText;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private TextMeshProUGUI timerText;

		[SerializeField]
		private GameObject activeRoot;

		[SerializeField]
		private GameObject timerRoot;

		[SerializeField]
		private ScriptableMiniBossRewardsData.Reward reward;

		[SerializeField]
		private FreebieType freebieType;

		private const int timerDuration = 28800;

		public static readonly Dictionary<FreebieType, string> TypeTimerKeys;

		private static readonly int Unlock;

		private Timer timer;

		private bool timerActive;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnPressed()
		{
		}

		private void TimeSpanChanged(Timer _)
		{
		}

		private void SetTimerActiveState(bool state)
		{
		}
	}
}
