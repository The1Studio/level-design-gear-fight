using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class VoidGearController : GearController
	{
		[SerializeField]
		private float incrementPerAttached;

		[SerializeField]
		private TextMeshPro displayText;

		[SerializeField]
		private Animator textAnimator;

		private readonly int deincrementHash;

		private readonly int incrementHash;

		private bool pendingRefresh;

		private int numTouching;

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
