using System.Collections.Generic;
using GearGame.Gameplay;
using GearGame.Gameplay.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Tutorials
{
	public class FourthTutorialController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Button rerollButton;

		[SerializeField]
		private GameObject fightObject;

		[SerializeField]
		private Vector2Int mergePegIndex;

		[SerializeField]
		private GearSellingController sellingController;

		[SerializeField]
		private PurchaseShopController shopController;

		private GearPeg mergePeg;

		private List<GearPeg> allPegs;

		private void Start()
		{
		}

		private void StateChangedPart1(GameStateManager.GameState state)
		{
		}

		private void IncrementTutorial(GearController _)
		{
		}

		private void FinalizeTutorial()
		{
		}
	}
}
