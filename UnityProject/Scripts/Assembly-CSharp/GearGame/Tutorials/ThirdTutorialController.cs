using System.Collections.Generic;
using GearGame.Gameplay;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class ThirdTutorialController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private GameObject rerollObject;

		[SerializeField]
		private GameObject fightObject;

		[SerializeField]
		private GearSellingController sellingController;

		[SerializeField]
		private Vector2Int firstPlacementPegIndex;

		[SerializeField]
		private Vector2Int startSwapPegIndex;

		[SerializeField]
		private Vector2Int endingPositionPegIndex;

		private GearPeg firstPlacementPeg;

		private GearPeg startSwapPeg;

		private GearPeg endingPositionPeg;

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

		private void IncrementTutorial2(GearController gear)
		{
		}

		private void StateChanged(GameStateManager.GameState _)
		{
		}
	}
}
