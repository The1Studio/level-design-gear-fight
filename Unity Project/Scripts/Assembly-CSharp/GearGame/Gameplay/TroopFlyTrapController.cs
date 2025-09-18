using System.Collections.Generic;
using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopFlyTrapController : TroopController
	{
		private FlyTrapData _data;

		[SerializeField]
		private GameObject meatObject;

		private readonly List<TroopController> hitEnemies;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void EnemyAttacked(TroopController controller)
		{
		}

		private void EnemyKilled(TroopController controller)
		{
		}
	}
}
