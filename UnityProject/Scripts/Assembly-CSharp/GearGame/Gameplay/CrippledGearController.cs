using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class CrippledGearController : GearController
	{
		[SerializeField]
		private float deincrementPerAttached;

		[SerializeField]
		private TextMeshPro displayText;

		[SerializeField]
		private Animator textAnimator;

		private readonly int deincrementHash;

		private readonly int incrementHash;

		private bool pendingRefresh;

		private int numTouching;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override bool CanBeFrozen => false;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override float GetScoreValue(float currentScoreValue)
		{
			return 0f;
		}

		private float GetValue()
		{
			return 0f;
		}

		private void DoRefresh()
		{
		}

		public void Refresh()
		{
		}
	}
}
