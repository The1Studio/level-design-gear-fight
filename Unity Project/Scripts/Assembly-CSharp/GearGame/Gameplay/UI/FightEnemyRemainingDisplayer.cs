using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI
{
	public class FightEnemyRemainingDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI displayValue;

		private FightGenerator.FightDetail fight;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void FightEnded(FightGenerator.FightDetail fight)
		{
		}

		private void FightStarted(FightGenerator.FightDetail fight)
		{
		}

		private void NumberChanged(int numberKilled)
		{
		}
	}
}
