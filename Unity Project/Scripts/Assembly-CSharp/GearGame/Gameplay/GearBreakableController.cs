using Gameplay._Data;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay
{
	public class GearBreakableController : GearController
	{
		[SerializeField]
		private Slider fillSlider;

		[SerializeField]
		private AudioSourceVariable breakSource;

		[SerializeField]
		private TextMeshProUGUI fillPercentText;

		[SerializeField]
		private Animator displayAnim;

		[SerializeField]
		private int numberRotationsRequired;

		private float targetProgress01;

		private int numberRotations;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override GearData GearData => null;

		public override bool CanBeFrozen => false;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		private new void StateChanged(GameStateManager.GameState state)
		{
		}

		public override void Rotate(float rotation, GearPeg startingPeg, GearPeg previousPeg)
		{
		}

		public override void BreakThis()
		{
		}
	}
}
