using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI.Pregame
{
	public class SkillChatBoxController : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI titleText;

		[SerializeField]
		private TextMeshProUGUI startingValueText;

		[SerializeField]
		private TextMeshProUGUI endingValueText;

		[SerializeField]
		private TextMeshProUGUI[] costTexts;

		[SerializeField]
		private GameObject yesAffordParent;

		[SerializeField]
		private GameObject noAffordParent;

		[SerializeField]
		private CurrencySO associatedCurrency;

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		private AudioSource cantAffordSource;

		[SerializeField]
		private Vector2 offset;

		private bool canAfford;

		private double cost;

		private double increment;

		private SkillButtonController skillButton;

		private ScriptableSkill skill;

		public void Initialize(ScriptableSkill skill, SkillButtonController skillButton, double increment, double cost)
		{
		}

		public void OnPressed()
		{
		}

		public void OnExit()
		{
		}
	}
}
