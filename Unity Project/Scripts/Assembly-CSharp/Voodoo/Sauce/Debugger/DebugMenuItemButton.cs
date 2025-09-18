using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	[RequireComponent(typeof(Button))]
	public class DebugMenuItemButton : Widget
	{
		[SerializeField]
		private Image menuIconImage;

		[SerializeField]
		private TextMeshProUGUI menuNameText;

		[SerializeField]
		private Badge badge;

		private Button _menuButton;

		private Action _callback;

		private BadgeCounter _counter;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetIcon(Sprite icon, Color color)
		{
		}

		public void SetText(string text)
		{
		}

		public void SetCallback(Action callback)
		{
		}

		public void SetBadgeCounter(BadgeCounter counter)
		{
		}

		private void OnButtonClick()
		{
		}

		private void OnBadgeValueUpdate(int count)
		{
		}
	}
}
