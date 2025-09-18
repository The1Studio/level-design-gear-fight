using UnityEngine;
using UnityEngine.UI;
using Voodoo.Sauce.Internal.DebugScreen;

namespace Voodoo.Sauce.Debugger.Widgets
{
	public class DebugSeparator : Widget, IDebugRefreshable
	{
		[SerializeField]
		private Image separatorImage;

		private RectTransform _rectTransform;

		private void Awake()
		{
		}

		public void SetSize(int height)
		{
		}

		public void DisplayLine(bool value = true)
		{
		}

		public void Refresh()
		{
		}
	}
}
