using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;
using Voodoo.Sauce.Core;

namespace GearGame.Gameplay.Managers
{
	public class EnemyManager : CharacterManager
	{
		[SerializeField]
		private ScriptableSkill incomeSkill;

		[SerializeField]
		private bool isDebugLevel;

		[SerializeField]
		private float spawnWiggleX;

		private int valuePerKill;

		private FightGenerator.FightDetail activeFight;

		private readonly List<Coroutine> allFightSpawnRoutines;

		private double levelTargetDifferentialMultiplier;

		private double levelDensityDifferentialMultiplier;

		private double levelBruteDifferentialMultiplier;

		private bool didWatchAD;

		private int[] gearDrops;

		private int gearDropOn;

		private ScriptableGear[] miniGears;

		public int NumSpawnsRemaining { get; private set; }

		public event Action<FightGenerator.FightDetail> OnFightStarted
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

		public event Action<FightGenerator.FightDetail> OnFightEnded
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

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnVoodooSauceInit(VoodooSauceInitCallbackResult result)
		{
		}

		private void GameStateChanged(GameStateManager.GameState state)
		{
		}

		private void TryApplyNIVMultipliers()
		{
		}

		public void RewardedADCompleted(bool status)
		{
		}

		public void StartFight(FightGenerator.FightDetail fightDetail, EnemyStructureController spawnedStructure)
		{
		}

		public override void AddCharacterToList(TroopController characterSpawn)
		{
		}

		public void Damage(int amount)
		{
		}

		public void ResetFight()
		{
		}

		public void Clear()
		{
		}

		private void EnemyKilled(TroopController enemy)
		{
		}

		public override void OnFightFinished()
		{
		}

		private void TryDropGear(TroopController enemy)
		{
		}
	}
}
