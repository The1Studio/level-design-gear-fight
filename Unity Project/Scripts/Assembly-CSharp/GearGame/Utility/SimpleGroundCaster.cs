using System;
using UnityEngine;

namespace GearGame.Utility
{
	public class SimpleGroundCaster : MonoBehaviour
	{
		[Flags]
		public enum Axis
		{
			None = 1,
			X = 2,
			Y = 4,
			Z = 8,
			All = 0xE
		}

		[SerializeField]
		private Transform transformToMove;

		[SerializeField]
		private Transform raycastOrigin;

		[SerializeField]
		private Axis axis;

		[SerializeField]
		private float raycastLength;

		[SerializeField]
		private bool useLocalOffset;

		[SerializeField]
		private Vector3 groundOffset;

		[SerializeField]
		private Vector3 raycastOffset;

		private void LateUpdate()
		{
		}

		public static bool RayCast(Vector3 pos, out Vector3 hitPoint, float distance = float.PositiveInfinity)
		{
			hitPoint = default(Vector3);
			return false;
		}

		public static bool RayCast(Vector3 pos, out Vector3 hitPoint, out Vector3 normal, float distance = float.PositiveInfinity)
		{
			hitPoint = default(Vector3);
			normal = default(Vector3);
			return false;
		}

		public static bool RayCast(Vector3 pos, float radius, out Vector3 hitPoint, float distance = float.PositiveInfinity, int mask = 8)
		{
			hitPoint = default(Vector3);
			return false;
		}

		public static Vector3 RayCast(Vector3 pos, float distance = float.PositiveInfinity)
		{
			return default(Vector3);
		}

		public static Vector3 RayCast(Vector3 pos, float radius, float distance = float.PositiveInfinity)
		{
			return default(Vector3);
		}
	}
}
