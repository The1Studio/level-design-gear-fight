using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Debugger
{
	public class DebugHideableSection : Widget
	{
		[SerializeField]
		private Button buttonShowHide;

		[SerializeField]
		private Image showHideImage;

		[SerializeField]
		private Sprite collapseSprite;

		[SerializeField]
		private Sprite expandSprite;

		private readonly List<GameObject> children;

		private bool isShown;

		public bool IsShown
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void AddChild(GameObject child)
		{
		}

		public void UpdateDisplay(bool show)
		{
		}
	}
}
