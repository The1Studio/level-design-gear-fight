using GearGame.Control;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class TroopUpgradeEvolutionController : MonoBehaviour
	{
		[SerializeField]
		private Image[] startingEvolutionImages;

		[SerializeField]
		private Image endingEvolutionImage;

		[SerializeField]
		private AudioSource source;

		public void TryActivate(ScriptableTroop character)
		{
		}
	}
}
