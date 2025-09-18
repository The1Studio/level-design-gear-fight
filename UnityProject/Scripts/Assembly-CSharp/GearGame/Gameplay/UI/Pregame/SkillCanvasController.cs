using System;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI.Pregame
{
	public class SkillCanvasController : SkillCanvasControllerLegacy
	{
		[Serializable]
		public class SkillSection
		{
			[field: SerializeField]
			public SkillButtonController[] AllSkillButtons { get; private set; }

			[field: SerializeField]
			public GameObject LockObject { get; private set; }

			[field: SerializeField]
			public GameObject BackgroundOff { get; private set; }

			[field: SerializeField]
			public float SectionY { get; private set; }

			public bool SectionUnlocked { get; set; }
		}

		[SerializeField]
		private SkillSection[] allSkillSections;

		[SerializeField]
		private Slider fillBarSlider;

		[SerializeField]
		private float startingFillBarPosition;

		[SerializeField]
		private float fillBarPositionIncrement;

		private bool hasInitialized;

		private float targetFillPosition;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Initialize()
		{
		}

		private float GetFillBarPosition()
		{
			return 0f;
		}

		public override bool HasAvailableUpgrade(double additionalCoins)
		{
			return false;
		}

		protected override void ItemUnlocked(SkillButtonController button)
		{
		}
	}
}
