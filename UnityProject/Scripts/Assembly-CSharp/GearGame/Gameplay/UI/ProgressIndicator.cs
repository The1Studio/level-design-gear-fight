using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class ProgressIndicator : MonoBehaviour
	{
		[Serializable]
		public class SliderNodeDetail
		{
			[field: SerializeField]
			public Sprite BackgroundSprite { get; private set; }

			[field: SerializeField]
			public Sprite FillSprite { get; private set; }

			[field: SerializeField]
			public float[] NodeFillStart { get; private set; }

			[field: SerializeField]
			public float[] NodeFillEnd { get; private set; }
		}

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private Image fillImage;

		[SerializeField]
		private TextMeshProUGUI progressText;

		[SerializeField]
		private SliderNodeDetail[] allNodeDetails;

		private SliderNodeDetail sliderNodeDetailUsed;

		private float targetPercent;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetProgressOnCurrentNode()
		{
		}

		private void FightIndexChanged(int _)
		{
		}
	}
}
