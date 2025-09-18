using Gameplay._Data;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopForestGuardianController : TroopController
	{
		private ForestGuardianData _data;

		[SerializeField]
		private GameObject prefabTree;

		public override TroopData Data => null;

		protected override void Start()
		{
		}

		private void Activate(TroopHealthController obj)
		{
		}
	}
}
