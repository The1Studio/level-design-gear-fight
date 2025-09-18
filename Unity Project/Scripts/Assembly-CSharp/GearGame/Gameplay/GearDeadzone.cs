using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GearDeadzone : MonoBehaviour, IGearHolder
	{
		[SerializeField]
		private RectTransform positionalTransform;

		[SerializeField]
		private float targetDeltaDistance;

		[SerializeField]
		private Vector2 targetSize;

		[SerializeField]
		private Transform[] spawnTransforms;

		private int spawnIndex;

		private readonly List<GearController> weaponDisplays;

		public GameObject GameObject => null;

		public float DefaultRotation => 0f;

		public bool CanBeUsedInSwaps => false;

		[field: SerializeField]
		public float ScaleMultiplier { get; private set; }

		public void AddGear(GearController weaponDisplay)
		{
		}

		public Vector3 GetRandomPosition()
		{
			return default(Vector3);
		}

		public void RemoveGear(GearController weaponDisplay)
		{
		}
	}
}
