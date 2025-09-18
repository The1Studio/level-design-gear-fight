using System;
using TMPro;
using UnityEngine;

namespace Voodoo.Distribution
{
	[Serializable]
	[RequireComponent(typeof(TMP_Text))]
	[DisallowMultipleComponent]
	public class FormattedTranslator : MonoBehaviour
	{
		[SerializeField]
		private string _formatedString;

		[SerializeField]
		private TMP_Text _textMesh;

		[SerializeField]
		private bool _atStart;

		[SerializeField]
		private bool _onEnable;

		public string[] keys;

		private TMP_Text TextMesh => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public virtual void Translate(string language = null)
		{
		}

		private void UpdateRightToLeft()
		{
		}

		public void SetFormattedString(string value)
		{
		}
	}
}
