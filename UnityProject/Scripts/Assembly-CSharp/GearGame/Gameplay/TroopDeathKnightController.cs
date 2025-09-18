using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopDeathKnightController : TroopController
	{
		private DeathKnightData _data;

		[SerializeField]
		private GroundAOEEffect fireAOEEffect;

		public override TroopData Data => null;

		protected override void Start()
		{
		}
	}
}
