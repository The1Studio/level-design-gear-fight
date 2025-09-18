using System;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SnakeMonsterBodyController : MonoBehaviour
	{
		[Serializable]
		private class ChainLink
		{
			[field: SerializeField]
			public Transform Transform { get; private set; }

			public Transform FollowTransform { get; set; }

			public float DefaultOffset { get; set; }

			public Vector3 LastPoint { get; set; }

			public Quaternion TargetRotation { get; set; }

			public bool SlerpRotation { get; set; }

			public void Update()
			{
			}
		}

		[SerializeField]
		private ChainLink[] allLinks;

		private Vector3 lastPosition;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
