using Gameplay._Data;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using JetBrains.Annotations;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearSpecialIncomeControlller : GearController
	{
		[SerializeField]
		private GameObject descriptionPopup;

		private bool hasUnfrozen;

		public override GearData GearData => null;

		public override bool CanBeFrozen => false;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Payout()
		{
		}

		private void FrozenStatusChanged(bool status)
		{
		}

		private bool CanPayout()
		{
			return false;
		}

		public override void CheckVariableStates()
		{
		}

		protected override void StateChanged(GameStateManager.GameState state)
		{
		}

		[UsedImplicitly]
		public void OnPayout()
		{
		}
	}
}
