using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopSpawnProjectileController : ProjectileController
	{
		[SerializeField]
		private ScriptableTroop troopSpawn;

		protected override void ExecuteAttack(TroopController targetEnemy, CharacterManager manager)
		{
		}
	}
}
