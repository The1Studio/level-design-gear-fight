using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Voodoo.Distribution
{
	[Serializable]
	[RequireComponent(typeof(TMP_Text))]
	[DisallowMultipleComponent]
	public class Translator : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textMesh;

		[FormerlySerializedAs("AtStart")]
		[SerializeField]
		private bool _atStart;

		[FormerlySerializedAs("AtEnable")]
		[SerializeField]
		private bool _onEnable;

		public string key;

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
	}
}
