using System.Collections.Generic;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using UnityEngine;
using VInspector;

namespace GearGame.Gameplay
{
	public class BlockerGearController : MonoBehaviour, ICustomGearInformationReceiver
	{
		public enum RotationType
		{
			None = 0,
			Clockwise = 1,
			AntiClockwise = 2
		}

		[SerializeField]
		private SerializedDictionary<GearController.MotionBlockDirection, float> allDirectionAngles;

		private readonly Dictionary<GearController.MotionBlockDirection, GearController.MotionBlockDirection> MotionRotationFromToClockwise;

		private readonly Dictionary<GearController.MotionBlockDirection, GearController.MotionBlockDirection> MotionRotationFromToAntiClockwise;

		[SerializeField]
		private Transform scalerRootTransform;

		private GearController attachedGear;

		private RotationType rotationType;

		private GearController.MotionBlockDirection currentDirection;

		private float rotationTarget;

		private float rotationCurrent;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void GenerateInformation(ScriptableGear gear, GearController.MotionBlockDirection blockDirection, RotationType rotationType)
		{
		}

		public void InformationReceived(string[] information, GearPeg targetPeg, bool _)
		{
		}

		private void GearChanged(GearController gear)
		{
		}

		private void SetDirection(GearController.MotionBlockDirection direction, bool instant)
		{
		}
	}
}
