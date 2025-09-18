using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellPoisonController : SpellLaunchedBomb
	{
		[SerializeField]
		private GameObject[] explosionObjects;

		[SerializeField]
		private float areaOfEffect;

		protected override void Explode()
		{
		}
	}
}
