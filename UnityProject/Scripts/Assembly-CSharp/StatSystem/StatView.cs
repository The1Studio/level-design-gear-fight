using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace StatSystem
{
	public class StatView : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _value;

		[SerializeField]
		private bool _modiferUnderParenthese;

		[SerializeField]
		[Range(0f, 100f)]
		private float _modifierSize;

		[Tooltip("Can be null and the modifier value will be on the value text")]
		[SerializeField]
		private TextMeshProUGUI _modifierValue;

		[SerializeField]
		private bool _useAcronym;

		[SerializeField]
		private TextMeshProUGUI _name;

		[SerializeField]
		private Image _icon;

		private StatFormatSO _settings;

		private StatFormat _format;

		public StatNames Stat { get; private set; }

		public void SetValue(float value, StatModifier modifier)
		{
		}

		public void SetValue(float value)
		{
		}

		public void Initialize(StatNames stat)
		{
		}
	}
}
