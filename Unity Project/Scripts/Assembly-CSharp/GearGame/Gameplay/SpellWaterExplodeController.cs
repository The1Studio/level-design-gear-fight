using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellWaterExplodeController : SpellLaunchedBomb
	{
		[SerializeField]
		private GameObject explosionObject;

		[SerializeField]
		private float areaOfEffect;

		protected override void Explode()
		{
		}
	}
}
