using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	public class TutorialButtonPressHelper : MonoBehaviour
	{
		public static Selectable SingleTarget;

		private bool didUpdateThisFrame;

		private readonly List<Selectable> allDisableSelectables;

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public static bool IsRaycastClean(Selectable target)
		{
			return false;
		}

		public void SetSingleTarget(Selectable target)
		{
		}
	}
}
