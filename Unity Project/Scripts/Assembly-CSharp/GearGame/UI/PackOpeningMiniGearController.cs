using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using GearGame.Gameplay.UI;
using Items;
using UnityEngine;
using UnityEngine.EventSystems;
using VInspector;

namespace GearGame.UI
{
	public class PackOpeningMiniGearController : MonoBehaviour, IPointerMoveHandler, IEventSystemHandler
	{
		[SerializeField]
		private SerializedDictionary<GearUpgradeUnlockProfile.Tier, UIFadeAway> tierDisplays;

		[SerializeField]
		private UIMiniGear uIMiniGear;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private AudioSourceVariable audioSource;

		[SerializeField]
		private AudioSourceVariable collectSource;

		[SerializeField]
		private float motionDelay;

		[SerializeField]
		private float motionAcceleration;

		private bool hasActivated;

		private bool hasStartedFinalAnimation;

		private float motionSpeed;

		private ScriptableGear gear;

		private SelectableGearController target;

		private float startingDistance;

		private TransactionLocation transactionLocation;

		public ScriptableGear Gear => null;

		public event Action<PackOpeningMiniGearController> OnTapped
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

		public event Action<PackOpeningMiniGearController> OnAnimationCompleted
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

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void Activate(ScriptableGear gear, TransactionLocation transactionLocation)
		{
		}

		public void OnTap()
		{
		}

		public void SetTarget(SelectableGearController display)
		{
		}

		public void OnPointerMove(PointerEventData eventData)
		{
		}
	}
}
