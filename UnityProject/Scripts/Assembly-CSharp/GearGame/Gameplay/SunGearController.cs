using GearGame.Control;
using GearGame.Gameplay.Managers;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class SunGearController : GearController
	{
		[SerializeField]
		private TextMeshPro displayText;

		[SerializeField]
		private float percentGainPerLevel;

		[SerializeField]
		private float startingPercent;

		[SerializeField]
		private Animator textAnimator;

		private float percentAdded;

		private float baseProduciton;

		private bool hasInitialized;

		private readonly int incrementHash;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override bool CanBeFrozen => false;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnMerge(GearController newGear, GearController gear1, GearController gear2)
		{
		}

		public override string GetProductionDisplayString()
		{
			return null;
		}

		private new void StateChanged(GameStateManager.GameState state)
		{
		}

		private void Initialize()
		{
		}

		private void Refresh()
		{
		}
	}
}
