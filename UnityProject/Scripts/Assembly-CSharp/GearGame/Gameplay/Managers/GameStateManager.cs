using System;
using System.Runtime.CompilerServices;
using GearGame.Control;
using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public class GameStateManager : MonoBehaviour
	{
		public enum GameState
		{
			Pregame = 0,
			Combat = 1,
			Store = 2,
			FailGame = 3,
			WinGame = 4,
			Transition = 5
		}

		private static GameStateManager instance;

		[SerializeField]
		private ScriptableGear[] debugGridSpawns;

		private GameState currentGameState;

		private float timeSpentInMission;

		public static GameStateManager Instance => null;

		public GameState CurrentGameState
		{
			get
			{
				return default(GameState);
			}
			private set
			{
			}
		}

		public float TimeSpentInMission => 0f;

		public event Action<GameState> OnStateChanged
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

		private void Update()
		{
		}

		public void SetGameState(GameState state)
		{
		}
	}
}
