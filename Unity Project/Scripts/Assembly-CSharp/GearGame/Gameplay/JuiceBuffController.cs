using UnityEngine;

namespace GearGame.Gameplay
{
	public class JuiceBuffController : BoostController
	{
		[SerializeField]
		private GameObject simpleBuffDisplayForSpawnedCharacters;

		protected override void ApplyGearModification(GearController gear)
		{
		}

		private void OnCharacterSpawned(TroopController character)
		{
		}

		protected override void RevertGearModification(GearController gear)
		{
		}
	}
}
