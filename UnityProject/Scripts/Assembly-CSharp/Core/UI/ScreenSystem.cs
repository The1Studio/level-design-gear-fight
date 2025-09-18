using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.UI
{
	public class ScreenSystem : MonoBehaviour
	{
		[SerializeField]
		private Screen[] _screens;

		private Dictionary<System.Type, Screen> _screenToScreen;

		private Screen _currentScreen;

		private void Awake()
		{
		}

		public T Open<T>(T screen) where T : Screen
		{
			return null;
		}

		public T Open<T>() where T : Screen
		{
			return null;
		}

		public T GetScreen<T>() where T : Screen
		{
			return null;
		}

		public bool IsScreenOpened<T>() where T : Screen
		{
			return false;
		}
	}
}
