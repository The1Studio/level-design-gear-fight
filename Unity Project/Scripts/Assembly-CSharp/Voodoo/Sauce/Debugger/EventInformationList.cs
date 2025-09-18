using TMPro;
using UnityEngine;

namespace Voodoo.Sauce.Debugger
{
	public class EventInformationList : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private Transform container;

		public Transform GetContainer => null;

		public void Initialize(string header)
		{
		}
	}
}
