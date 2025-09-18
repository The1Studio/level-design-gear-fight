using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopForestGolemController : TroopController
	{
		private ForestGolemData _data;

		[SerializeField]
		private GameObject rollingStoneAttack;

		[SerializeField]
		private Transform attackSpawnTransform;

		[SerializeField]
		private TroopCombatController characterCombatController;

		private float attackTimer;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private void SpawnAttack()
		{
		}
	}
}
