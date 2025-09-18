using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.Misc
{
	public class HealthBarController : MonoBehaviour, IPooledObject
	{
		[SerializeField]
		private Slider healthSlider;

		[SerializeField]
		private Slider shieldingSlider;

		[SerializeField]
		private Slider damageSlider;

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		private TextMeshProUGUI displayHealth;

		private double healthPercent01;

		private double shieldingPercent01;

		private double maxHealth;

		private double health;

		private double shielding;

		private float healthDisplayValue;

		private float shieldingDisplayValue;

		private float damageDisplayValue;

		private float healthSliderDelay;

		private float shieldingSliderDelay;

		private float damageSliderDelay;

		private bool destroyOnComplete;

		private TroopHealthController healthController;

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize(TroopHealthController healthController, bool destroyOnComplete = false, bool enabledByDefault = false)
		{
		}

		private void OnKilled(TroopHealthController obj)
		{
		}

		private void MaxHealthChanged(TroopHealthController controller, double maxHealthValue)
		{
		}

		private void ShieldingChanged(TroopHealthController arg1, double shieldingValue)
		{
		}

		private void OnHealthChanged(TroopHealthController controller, double healthValue)
		{
		}

		private void UpdateDisplay(bool instant = false)
		{
		}

		public void OnObjectSpawn()
		{
		}
	}
}
