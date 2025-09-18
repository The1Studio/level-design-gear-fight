using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI
{
	public class PlayerHealthDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI displayValue;

		[SerializeField]
		private Animator animator;

		private int lastCheckedHealthValue;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void HealthChanged(int num)
		{
		}
	}
}
