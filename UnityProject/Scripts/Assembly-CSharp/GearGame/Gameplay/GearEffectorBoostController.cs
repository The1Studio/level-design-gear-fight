using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearEffectorBoostController : GearEffectorController
	{
		[SerializeField]
		private float productionMultiplierAddition;

		protected override void ApplyEffect(GearPeg[] pegs)
		{
		}

		protected override void RevertEffect(GearPeg[] pegs)
		{
		}
	}
}
