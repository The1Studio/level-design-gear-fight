using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellFrostController : SpellLaunchedBomb
	{
		[SerializeField]
		private AudioSource iceSoundSource;

		[SerializeField]
		private GameObject[] explosionObjects;

		[SerializeField]
		private float areaOfEffect;

		protected override void Explode()
		{
		}
	}
}
