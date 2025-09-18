using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using GearGame.Gameplay;
using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class PlayerLoadoutManager : MonoBehaviour
	{
		private static PlayerLoadoutManager instance;

		[SerializeField]
		private ScriptablePack defaultPack;

		[SerializeField]
		private ScriptablePack[] allPacks;

		[SerializeField]
		private ScriptableGlobalGameplayBoostData playerXPMultiplier;

		private ScriptablePack activePack;

		private readonly List<GameObject> currentStartingTroops;

		public static PlayerLoadoutManager Instance => null;

		public ScriptablePack ActivePack
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ScriptablePack DefaultPack => null;

		public ScriptablePack[] AllPacks => null;

		public ScriptableGlobalGameplayBoostData PlayerXPMultiplier => null;

		public event Action<ScriptablePack> OnActivePackChanged
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

		public void Awake()
		{
		}

		protected void Start()
		{
		}

		public int GetMaxLevel()
		{
			return 0;
		}

		public int GetTotalNuberOfUpgrades()
		{
			return 0;
		}

		public double GetNetInvestmentValue()
		{
			return 0.0;
		}

		public ScriptableGear[] GenerateGears(int currentLevel, int maxTier, bool isPremium, ref List<GearController> existingGears)
		{
			return null;
		}
	}
}
