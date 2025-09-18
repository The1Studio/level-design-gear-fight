using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellFireballController : SpellLaunchedBomb
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
