using AssetKits.ParticleImage;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay.UI
{
	public class CoinDisplayController : MonoBehaviour
	{
		[SerializeField]
		private ParticleImage particleImage;

		[SerializeField]
		private ParticleImage particleImageBurst;

		[SerializeField]
		private TextMeshProUGUI displayText;

		[SerializeField]
		private AudioSourceVariable source;

		public static Vector3 ScreenCenter => default(Vector3);

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void CoinsChanged(float _)
		{
		}

		public void SpawnCurrency(Vector2 position)
		{
		}

		public void BurstCurrency(Vector2 position, int amount)
		{
		}

		private void PayDownOutstanding()
		{
		}

		private void Refresh()
		{
		}

		private void JumpToActualValue()
		{
		}

		protected virtual void UpdateDisplayValue(float value)
		{
		}
	}
}
