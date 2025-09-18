using Core.UI;
using GearGame.Control;
using UnityEngine;

namespace GearGame.UI
{
	public abstract class PackUnlockedPopup : Popup
	{
		[SerializeField]
		protected ScriptablePack pack;
	}
}
