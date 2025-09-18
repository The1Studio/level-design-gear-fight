using System;
using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay.Misc
{
	public class ParalaxManager : MonoBehaviour
	{
		[Serializable]
		public class ParalaxZone
		{
			[field: SerializeField]
			public GameObject Root { get; private set; }

			[field: SerializeField]
			public float MotionMultiplier { get; private set; }

			[field: SerializeField]
			public bool ClampToTopOfCamera { get; private set; }

			public ParalaxZone(GameObject root, float motionMultiplier)
			{
			}
		}

		[SerializeField]
		private ParalaxZone[] allZones;

		private Camera cam;

		private readonly List<ParalaxZone> activeZones;

		private float lastCheckedXPosition;

		private void LateUpdate()
		{
		}

		public void SetCamera(Camera cam2d)
		{
		}
	}
}
