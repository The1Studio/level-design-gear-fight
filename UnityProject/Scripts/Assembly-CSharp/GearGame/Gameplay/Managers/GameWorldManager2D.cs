using System;
using UnityEngine;

namespace GearGame.Gameplay.Managers
{
	public class GameWorldManager2D : MonoBehaviour
	{
		private static GameWorldManager2D instance;

		[SerializeField]
		private PurchaseShopController basicShop;

		[SerializeField]
		private PurchaseShopController premiumShop;

		[SerializeField]
		private GameObject gameplayRoot;

		private GameStateManager.GameState lastState;

		private Action _startFightCallback;

		public static GameWorldManager2D Instance => null;

		public PurchaseShopController OpenShop { get; private set; }

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public void Init(Action startGameDelegate)
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}
	}
}
