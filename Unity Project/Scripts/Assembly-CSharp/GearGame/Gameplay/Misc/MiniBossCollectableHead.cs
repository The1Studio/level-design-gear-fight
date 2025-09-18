using System;
using DG.Tweening;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay.Misc
{
	public class MiniBossCollectableHead : MonoBehaviour
	{
		[SerializeField]
		private ShadowProjector shadowProjector;

		[SerializeField]
		private SpriteRenderer displaySprite;

		[SerializeField]
		private GameObject shineObject;

		[SerializeField]
		private float delayBeforeAutoCollect;

		[SerializeField]
		private AudioSource landingSource;

		[SerializeField]
		private AnimationCurve motionCurve;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private float tapRange;

		private Tween jump;

		private bool isCollected;

		private bool isChest;

		private Action _onPopupOpenCallback;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		private void CollectThis()
		{
		}

		private void OnLanded()
		{
		}

		public void Initialize(Sprite displaySprite = null, bool isChest = false, Action onPopupOpenCallback = null)
		{
		}

		public void JumpTowardsCenter()
		{
		}
	}
}
