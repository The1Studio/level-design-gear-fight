using Coffee.UIExtensions;
using GearGame.Control;
using TMPro;
using UnityEngine;

namespace Items
{
	public class CurrencyView : MonoBehaviour, IViewRoot
	{
		[SerializeField]
		private CurrencySO _currency;

		[SerializeField]
		private TextMeshProUGUI _amount;

		[SerializeField]
		private UIParticleAttractor _attractor;

		private ParticleItemAnimation _animator;

		private double _prevAmount;

		[field: SerializeField]
		public RectTransform Root { get; set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAnimationUpdate(bool isAnimating)
		{
		}

		private void OnAttracted()
		{
		}

		private void OnAmountChanged(double amount)
		{
		}
	}
}
