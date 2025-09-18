using System.Collections.Generic;
using Core.UI;
using UnityEngine;

namespace UI.Refactor
{
	[CreateAssetMenu(fileName = "PopupsSettings", menuName = "UI/PopupSettings", order = 0)]
	public class PopupsSettings : ScriptableObject
	{
		public List<Popup> Popups;

		public T GetPopup<T>() where T : Popup
		{
			return null;
		}
	}
}
