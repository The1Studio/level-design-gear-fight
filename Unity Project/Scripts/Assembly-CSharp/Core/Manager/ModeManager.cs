using System;
using System.Collections.Generic;
using Core.Flow;
using UnityEngine;

namespace Core.Manager
{
	public class ModeManager : MonoBehaviour
	{
		[SerializeField]
		private Mode[] _modes;

		[SerializeField]
		private Mode _initialMode;

		private Mode _currentMode;

		private Dictionary<System.Type, Mode> _modesDictionary;

		public Mode CheatCurrentMode => null;

		private void Awake()
		{
		}

		private void ChangeMode(System.Type type)
		{
		}
	}
}
