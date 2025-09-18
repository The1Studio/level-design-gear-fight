using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class FrostGolemAttack : MonoBehaviour
	{
		[SerializeField]
		private GameObject freezeGearGameObject;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private float motionTime;

		[SerializeField]
		private AudioSource frostImpact;

		private static List<GearController> pendingTargets;

		private void Start()
		{
		}
	}
}
