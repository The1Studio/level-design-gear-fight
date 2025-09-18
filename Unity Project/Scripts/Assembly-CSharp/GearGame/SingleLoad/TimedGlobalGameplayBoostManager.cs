using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Timers;
using GearGame.Control;
using UnityEngine;

namespace GearGame.SingleLoad
{
	public class TimedGlobalGameplayBoostManager : MonoBehaviour
	{
		private static TimedGlobalGameplayBoostManager instance;

		[SerializeField]
		private ScriptableGlobalGameplayBoostData[] allBoosts;

		private readonly Dictionary<ScriptableGlobalGameplayBoostData, Timer> allBoostTimers;

		public static TimedGlobalGameplayBoostManager Instance => null;

		public event Action<ScriptableGlobalGameplayBoostData, bool, Transform> OnActivationStatusChanged
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

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public bool IsBoostActive(ScriptableGlobalGameplayBoostData boostData)
		{
			return false;
		}

		public Timer TryGetTimer(ScriptableGlobalGameplayBoostData scriptableBoostData)
		{
			return null;
		}

		public void ActivateBoost(ScriptableGlobalGameplayBoostData scriptableBoostData, Transform positionUsed)
		{
		}

		private void TimerElapsed(Timer timer)
		{
		}

		private void SubscribeToTimer(Timer timer)
		{
		}

		private void UnsubscribeFromTimer(Timer timer)
		{
		}
	}
}
