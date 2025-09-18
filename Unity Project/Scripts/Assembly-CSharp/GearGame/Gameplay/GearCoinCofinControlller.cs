using System;
using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearCoinCofinControlller : GearSpellSpawnerController
	{
		[Serializable]
		public class Evolution
		{
			[field: SerializeField]
			public int TotalNumberOfBodies { get; private set; }

			[field: SerializeField]
			public float ProductionMultiplier { get; private set; }

			[field: SerializeField]
			public Sprite DisplaySprite { get; private set; }
		}

		[SerializeField]
		private Evolution[] allEvolutions;

		[SerializeField]
		private SpriteRenderer spriteRegular;

		private Evolution currentEvolution;

		private float baselineRequiredNumber;

		private int evolutionOn;

		private int currentBodies;

		public override GearSpawnerData SpawnerData => null;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Unsubscribe()
		{
		}

		protected override void DoSpawnAction()
		{
		}

		private void CharacterKilled(TroopController _)
		{
		}

		private bool IsMaxEvolution()
		{
			return false;
		}

		private void IncrementBodies()
		{
		}

		private void SetEvolution(Evolution evolution)
		{
		}
	}
}
