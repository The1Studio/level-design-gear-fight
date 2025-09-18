using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class CustomEquippedGearSlotDisplayController : MonoBehaviour
	{
		[SerializeField]
		private GameObject lockedRoot;

		[SerializeField]
		private GameObject unlockedRoot;

		[SerializeField]
		private GameObject hasGearRoot;

		[SerializeField]
		private Image gearBackgroundImage;

		[SerializeField]
		private GameObject upgradeObject;

		[SerializeField]
		private Image[] gearForegroundImages;

		[SerializeField]
		private TextMeshProUGUI gearDisplayNumber;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private GearLevelDisplayController gearLevelDisplayController;

		[SerializeField]
		private int index;

		private readonly int wiggleHash;

		private readonly int activeHash;

		private bool hasInitialized;

		private ScriptableGear lastSelectedGear;

		public bool HasGear { get; private set; }

		public int Index => 0;

		public event Action<CustomEquippedGearSlotDisplayController> OnClicked
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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetWiggleStatus(bool status)
		{
		}

		public void OnClick()
		{
		}

		private void LoadoutChanged(IList<ScriptableGear> gears)
		{
		}

		private void GearNumberChanged(ScriptableGear gear, int num)
		{
		}

		private void SetUnlockedStatus(bool status)
		{
		}
	}
}
