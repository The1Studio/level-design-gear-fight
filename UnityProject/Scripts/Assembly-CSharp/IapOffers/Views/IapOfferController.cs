using UnityEngine;

namespace IapOffers.Views
{
	public class IapOfferController : MonoBehaviour
	{
		private static bool _hasTriedToAutoShow;

		[SerializeField]
		private IapOfferMenuButton _starterPackOffer;

		[SerializeField]
		private IapOfferMenuButton _troopPackOffer;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Refresh()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnLoad()
		{
		}
	}
}
