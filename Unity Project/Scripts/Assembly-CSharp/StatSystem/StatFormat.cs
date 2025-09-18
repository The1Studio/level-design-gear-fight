using System;
using UnityEngine;

namespace StatSystem
{
	[Serializable]
	public struct StatFormat
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private string _nameLocalizationKey;

		public Sprite Icon;

		public string Acronym;

		[SerializeField]
		[Header("Value Formating")]
		private bool _isPercentage;

		[SerializeField]
		private bool _roundValue;

		[SerializeField]
		private string _format;

		public string Name => null;

		public string FormatValue(float value)
		{
			return null;
		}

		private string ConstructFormat(StatModifier modifier, bool isPercentage, Color color, float size, bool withParentheses)
		{
			return null;
		}

		public string FormatValue(StatModifier modifier, Color color, float size = 100f, bool withParentheses = true)
		{
			return null;
		}
	}
}
