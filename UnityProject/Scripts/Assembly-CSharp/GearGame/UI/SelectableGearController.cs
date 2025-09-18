using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using GearGame.Gameplay.UI;
using GearGame.SingleLoad;
using UnityEngine;

namespace GearGame.UI
{
	public class SelectableGearController : MonoBehaviour
	{
		[SerializeField]
		private GameObject selectedParent;

		[SerializeField]
		private IndividualGearDisplayController individualGearDisplayController;

		[SerializeField]
		[Tooltip("Optional for now - probably going to AB test this. Used for the mini-gears")]
		private UpgradableGearDisplayController upgradableGearDisplayController;

		[SerializeField]
		private UIMiniGear uIMiniGear;

		[SerializeField]
		private GearLevelDisplayController gearLevelDisplayController;

		private GearEquippingCanvas canvas;

		private ScriptableGear gear;

		private bool selected;

		public IndividualGearDisplayController IndividualGearDisplayController => null;

		public UpgradableGearDisplayController UpgradableGearDisplayController => null;

		public bool Selected => false;

		public event Action<PlayerCustomGearLoadoutManager.TryEquipResult> OnClickedCallback
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

		private void OnDestroy()
		{
		}

		public void Initialize(ScriptableGear gear, GearEquippingCanvas canvas)
		{
		}

		private void LoadoutChanged(IList<ScriptableGear> obj)
		{
		}

		public void OnPressed()
		{
		}
	}
}
