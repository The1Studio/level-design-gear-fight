using UnityEngine;
using UnityEngine.UI;

namespace GearGame.UI
{
	public class UIAudioSlider : MonoBehaviour
	{
		[SerializeField]
		private bool _isSFXSlider;

		[SerializeField]
		private Slider _slider;

		private void Awake()
		{
		}

		private void OnValueChanged(float value)
		{
		}
	}
}
