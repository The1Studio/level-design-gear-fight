using System;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class FallingPegController : GearPeg, ICustomGearInformationReceiver
	{
		[SerializeField]
		private GameObject pendingFalloffObject;

		[SerializeField]
		private SpriteRenderer rendererForBasePeg;

		[SerializeField]
		private Rigidbody2D rb;

		[SerializeField]
		private GameObject warningObject;

		private bool pendingFallStatus;

		public int WaveToActivate { get; private set; }

		public event Action<FallingPegController> OnDestroyed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void InformationReceived(string[] information, GearPeg targetPeg, bool _)
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void SetPendingFallStatus(bool status)
		{
		}

		protected override bool ValidatePegGlow(GearController gear)
		{
			return false;
		}

		public void KillThis()
		{
		}
	}
}
