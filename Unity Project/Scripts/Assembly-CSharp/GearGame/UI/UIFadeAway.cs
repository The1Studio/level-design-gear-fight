using AssetKits.ParticleImage;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class UIFadeAway : MonoBehaviour
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private ParticleImage particleImage;

		[SerializeField]
		private float fadeRate;

		public void FadeAway()
		{
		}
	}
}
