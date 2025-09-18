using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopIceGolemController : TroopController
	{
		private IceGolemData _data;

		[SerializeField]
		private GameObject frozenAttack;

		[SerializeField]
		private Transform attackSpawnTransform;

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
