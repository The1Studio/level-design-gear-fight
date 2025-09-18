using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.UI
{
	[CreateAssetMenu(fileName = "PopupDictionnary", menuName = "Voodoo/UI/PopupDictionnary", order = 0)]
	public class PopupDictionnarySO : ScriptableObject
	{
		public Popup[] Popups;

		private Dictionary<System.Type, Popup> _popupDictionnary;

		public T Get<T>() where T : Popup
		{
			return null;
		}
	}
}
