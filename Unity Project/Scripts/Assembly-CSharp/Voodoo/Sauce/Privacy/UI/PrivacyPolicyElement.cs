using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class PrivacyPolicyElement : MonoBehaviour
	{
		public struct ConsentLineParameters
		{
			public string text;

			public UnityAction buttonAction;
		}

		public void Initialize(ConsentLineParameters p)
		{
		}
	}
}
