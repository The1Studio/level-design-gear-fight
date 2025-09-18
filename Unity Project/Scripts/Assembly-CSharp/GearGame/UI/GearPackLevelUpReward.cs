using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.UI
{
	public class GearPackLevelUpReward : MonoBehaviour
	{
		[SerializeField]
		private Transform spawnTransform;

		[SerializeField]
		private GameObject gearRewardPrefab;

		[SerializeField]
		private GameObject gearCurrencyRewardPrefab;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private GameObject newGearParent;

		private CurrencySO currency;

		private double amount;

		private ScriptableGear gear;

		private string guid;

		private bool hasActivated;

		private GameObject currentDisplayObject;

		public event Action<GearPackLevelUpReward> OnPayout
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

		public void Clear()
		{
		}

		public void Initialize(ScriptablePack pack, ScriptableGear gear)
		{
		}

		public void Initialize(CurrencySO currency, double amount, string GUID)
		{
		}

		public void OnTapped()
		{
		}

		public void Payout()
		{
		}
	}
}
