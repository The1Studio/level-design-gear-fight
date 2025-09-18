using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearEffectorFreezeController : GearEffectorController
	{
		[SerializeField]
		private GameObject iceGearPrefab;

		private readonly List<IceGearController> allIceGears;

		protected override void ApplyEffect(GearPeg[] pegs)
		{
		}

		protected override void RevertEffect(GearPeg[] pegs)
		{
		}

		private void Freeze(GearController gear)
		{
		}
	}
}
