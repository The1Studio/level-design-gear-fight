using TMPro;
using UnityEngine;

namespace GearGame.Utility
{
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class GameVersionDisplay : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI text;

		private void Awake()
		{
		}

		private void SetDisplay()
		{
		}
	}
}
