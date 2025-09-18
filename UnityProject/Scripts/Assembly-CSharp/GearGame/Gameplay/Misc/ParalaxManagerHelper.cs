using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay.Misc
{
	public class ParalaxManagerHelper : MonoBehaviour
	{
		private const float purchaseCameraYPosition = 4.41f;

		private readonly List<ParalaxManager.ParalaxZone> activeZones;

		private Camera cam;

		private void LateUpdate()
		{
		}

		public void Initialize(List<ParalaxManager.ParalaxZone> zones, Camera cam)
		{
		}

		private void UpdatePosition()
		{
		}
	}
}
