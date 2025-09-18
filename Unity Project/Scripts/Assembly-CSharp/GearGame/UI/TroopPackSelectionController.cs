using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.UI
{
	public class TroopPackSelectionController : MonoBehaviour
	{
		[SerializeField]
		private TroopRootCanvas rootCanvas;

		[SerializeField]
		private PackSelectedDisplayController packSelectedDisplayController;

		private ScriptablePack activePack;

		public TroopRootCanvas RootCanvas => null;

		public event Action<ScriptablePack> OnSelectedPackChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		public void PackClicked(ScriptablePack pack)
		{
		}

		public void ActivatePack(ScriptablePack pack)
		{
		}
	}
}
