using UnityEngine;
using VInspector;

namespace GearGame.Gameplay
{
	public class GearAudioReferenceContainer : MonoBehaviour
	{
		public enum Audio
		{
			PickUp = 0,
			PlaceDown = 1,
			Merge = 2,
			Sell = 3,
			Purchase = 4,
			FailPurchase = 5,
			Rotation = 6
		}

		[SerializeField]
		private SerializedDictionary<Audio, AudioSource> AllSources;

		public void TryPlay(Audio audio)
		{
		}

		public void Sell()
		{
		}
	}
}
