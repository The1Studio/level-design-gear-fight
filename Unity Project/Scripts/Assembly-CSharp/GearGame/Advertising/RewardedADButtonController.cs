using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using Items;
using UnityEngine;
using UnityEngine.Events;

namespace GearGame.Advertising
{
	public class RewardedADButtonController : MonoBehaviour
	{
		public UnityEvent<bool> OnRewardedADCompleted;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private bool triggerAnalytics;

		[SerializeField]
		private string id;

		[SerializeField]
		private Transform clickTweenTarget;

		[SerializeField]
		private TransactionLocation transactionLocation;

		private CurrencySO _skipTickets;

		private readonly int loadingHash;

		private readonly int adTicketHash;

		private bool isFree;

		private string details;

		private Coroutine routine;

		private CurrencySO SkipTicket => null;

		public static event Action<bool> StaticRewardedADCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		public void SetID(string id)
		{
		}

		private void SkipTicketValueChanged(double val)
		{
		}

		public void OnClick()
		{
		}

		public bool TryShowRewardedVideo(string details = "")
		{
			return false;
		}

		private void OnRewardedVideoCompleted(bool status)
		{
		}

		private void SetRewardedAvailableStatus(bool status)
		{
		}

		public void IncrementRVEngagement()
		{
		}

		public int GetRVEngagement()
		{
			return 0;
		}
	}
}
