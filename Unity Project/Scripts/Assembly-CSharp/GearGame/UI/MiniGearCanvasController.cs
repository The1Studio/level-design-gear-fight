using System.Collections.Generic;
using GearGame.Control;
using GearGame.Gameplay.UI;
using Items;
using UnityEngine;

namespace GearGame.UI
{
	public class MiniGearCanvasController : MonoBehaviour
	{
		public enum CollectionType
		{
			Jump = 0,
			BurstCollect = 1
		}

		[SerializeField]
		private GameObject miniGearUIPrefab;

		[SerializeField]
		private Transform targetPositionForCollection;

		[SerializeField]
		private Animator collectionAnimator;

		[SerializeField]
		private AnimationCurve jumpCurve;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private AnimationCurve firstMotionCurve;

		[SerializeField]
		private float firstMotionDistance;

		[SerializeField]
		private float firstMotionDuration;

		[SerializeField]
		private AnimationCurve secondMotionCurve;

		[SerializeField]
		private float secondMotionDuration;

		private readonly List<UIMiniGear> allActiveGears;

		private readonly int activeHash;

		private readonly int collectHash;

		private TransactionLocation location;

		private void Awake()
		{
		}

		public void SpawnFromWorldPosition(Vector2 worldPosition, CollectionType collectionType, TransactionLocation location, ScriptableGear[] gears)
		{
		}

		public void SpawnFromScreenPosition(Vector2 screenPosition, CollectionType collectionType, TransactionLocation location, ScriptableGear[] gears)
		{
		}

		private void DoAnimation(UIMiniGear gear, CollectionType collectionType)
		{
		}

		private void RemoveGear(UIMiniGear gear)
		{
		}

		private void SetBookActivationStatus(bool status)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
