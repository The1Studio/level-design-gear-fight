using UnityEngine;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal class FakeNativeAd : FakeAd
	{
		[SerializeField]
		private Image _image;

		[SerializeField]
		private Sprite _squarreImage;

		[SerializeField]
		private Sprite _rectangleImage;

		[SerializeField]
		private RectTransform _transform;

		public void Setup(string layoutName, float x, float y, float width, float height)
		{
		}
	}
}
