using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class BulletController : MonoBehaviour
	{
		[SerializeField]
		private float movementTime;

		[SerializeField]
		private float deltaForImpact;

		[SerializeField]
		private TrailRenderer trailRenderer;

		[SerializeField]
		private GameObject impactObject;

		private float killY;

		private double damage;

		private float critMultiplier;

		private readonly HashSet<TroopController> ignoreCharacters;

		public Vector3 Direction { get; set; }

		protected virtual void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetAttackInformation(double damage, float critMultiplier)
		{
		}

		private void DisconnectTrail()
		{
		}
	}
}
