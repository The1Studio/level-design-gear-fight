using System.Collections.Generic;
using UnityEngine;
using Voodoo.Live.Offers;

namespace Voodoo.Live.Debugger
{
	public class TriggersSection : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TriggerButton _buttonPrefab;

		[SerializeField]
		private GameObject _triggersButtonLinePrefab;

		[SerializeField]
		private Transform _contentTransform;

		private List<string> _triggers;

		private int _triggersCount;

		private Transform _currentLineTR;

		public void Init(FeatureClient client)
		{
		}
	}
}
