using Core.UI;
using GearGame.Control;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class TroopUnlockCanvas : Popup
	{
		[SerializeField]
		private Image[] displayImages;

		private ScriptableTroop character;

		public void Activate(ScriptableTroop character)
		{
		}

		public void OnAnimationCompleted()
		{
		}
	}
}
