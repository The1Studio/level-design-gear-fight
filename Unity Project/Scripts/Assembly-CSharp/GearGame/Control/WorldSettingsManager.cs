using System;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.Managers;
using UnityEngine;
using UnityEngine.Audio;

namespace GearGame.Control
{
	public class WorldSettingsManager : MonoBehaviour
	{
		private static WorldSettingsManager instance;

		[SerializeField]
		private AudioMixer _audioMixer;

		private GameStateManager gameStateManager;

		private float _timeScaleOverride;

		private float _timeScale;

		public static WorldSettingsManager Instance => null;

		public static int QualityLevel { get; private set; }

		public static float MusicLevel { get; private set; }

		public static float SFXLevel { get; private set; }

		public static float SideArmSensitivity { get; private set; }

		public static float SniperSensitivity { get; private set; }

		public static bool IsHapticEnabled { get; private set; }

		public static bool HasInitialized { get; private set; }

		public static bool DebugOverrideTimescale { get; set; }

		public static bool DoubleSpeedActive { get; private set; }

		public static bool IsPaused { get; private set; }

		public static event Action<float> OnMusicValueChanged
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

		public static event Action<float> OnSFXValueChanged
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

		public static event Action<bool> OnDoubleSpeedActiveStatusChanged
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

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		public void AttachToGameStateManager(GameStateManager stateManager)
		{
		}

		private void UpdateTimeScale()
		{
		}

		private void SetTimeScale(float timeScale)
		{
		}

		public void TriggerDoubleTimescale()
		{
		}

		public void SetTimescaleStatus(bool status)
		{
		}

		public void SetBaseTimeScaleSpeed(float timeScale)
		{
		}

		public void SetPause(bool pause)
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		public void SetSFXVolumeLevel(float value01)
		{
		}

		public void SetMusicVolumeLevel(float value01)
		{
		}

		public void SetHapticActivationStatus(bool status)
		{
		}
	}
}
