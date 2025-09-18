using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class DebuggerHeader : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _title;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private Button _backButton;

		[SerializeField]
		private GameObject _devBuild;

		private void Awake()
		{
		}

		public void UpdateTarget(Screen screen)
		{
		}
	}
}
