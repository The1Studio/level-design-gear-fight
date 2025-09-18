using System;
using DG.Tweening;
using UnityEngine;

namespace ColorMatch.Utility
{
	[CreateAssetMenu(menuName = "Gameplay/Utility/Tween Sequence")]
	public class ScriptableTweenSequence : ScriptableObject
	{
		[Serializable]
		public class TweenWrapper
		{
			public enum TweenType
			{
				Move = 0,
				Scale = 1,
				Jump = 2,
				Rotation = 3
			}

			public enum TweenJoinType
			{
				Append = 0,
				Join = 1
			}

			[SerializeField]
			private TweenType tweenType;

			[SerializeField]
			private float delay;

			[SerializeField]
			[ReadOnly]
			private bool usingSplitDurations;

			[Tooltip("The duration of this tween ONLY USED IF SPLIT DURATIONS IS CHECKED!")]
			[SerializeField]
			private float duration;

			[SerializeField]
			private AnimationCurve curve;

			[Tooltip("Relative scale to where it began. Eg, if the scale is 3 and we do a relative scale of 1.5 it would become 4.5 if not it would scale down to 1.5")]
			[SerializeField]
			private bool doRelativeScale;

			[SerializeField]
			private float scaleValue;

			[Tooltip("The height of the jump (using the Y axis as up)")]
			[SerializeField]
			private float jumpHeight;

			[Tooltip("The target rotation in Euler angles")]
			[SerializeField]
			private Vector3 rotationTarget;

			[SerializeField]
			private TweenJoinType joinType;

			public void SetSplitDuration(bool status)
			{
			}

			public void AddTweenToSequence(Sequence s, Transform movingTransform, Vector3 targetPosition, bool isLocal, float speedMultiplier, float duration = -1f)
			{
			}

			public Tween GenerateTween(Transform movingTransform, Vector3 targetPosition, bool isLocal, float duration)
			{
				return null;
			}
		}

		[SerializeField]
		[Tooltip("Is the tween speed based? I.e. IF NOT SPEED BASED: if we need to move 15 units and set the duration to 5 it would move to the destination in 5 seconds no matter what (average 3 units per second). IF SPEED BASED: the motion will take longer if it's further away and the speed will be based on the duration")]
		private bool isSpeedBased;

		[SerializeField]
		private TweenWrapper[] allTweens;

		[SerializeField]
		[Tooltip("Each tween can have its own duration - if false they all have the same")]
		private bool splitDurations;

		[SerializeField]
		private float duration;

		private void OnValidate()
		{
		}

		public Sequence GenerateSequence(Transform movingTransform, Vector3 targetPosition, bool isLocal, float speedMultiplier, float additionalDelay)
		{
			return null;
		}
	}
}
