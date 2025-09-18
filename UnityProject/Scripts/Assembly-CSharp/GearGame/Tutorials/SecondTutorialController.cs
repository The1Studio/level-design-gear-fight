using System.Collections.Generic;
using GearGame.Gameplay;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Tutorials
{
	public class SecondTutorialController : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private GameObject rerollObject;

		[SerializeField]
		private GameObject fightObject;

		[SerializeField]
		private Vector2Int targetPegIndex;

		[SerializeField]
		private Vector2Int swapPegIndex;

		[SerializeField]
		private GearSellingController sellingController;

		private GearPeg targetPeg;

		private GearPeg swapPeg;

		private List<GearPeg> ignorePegs;

		private GearController startingGear;

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
