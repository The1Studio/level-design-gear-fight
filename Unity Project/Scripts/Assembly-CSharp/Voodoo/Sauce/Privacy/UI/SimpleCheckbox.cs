using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Voodoo.Sauce.Privacy.UI
{
	[RequireComponent(typeof(Image))]
	public class SimpleCheckbox : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[SerializeField]
		private Sprite _uncheckedSprite;

		[SerializeField]
		private Sprite _checkedSprite;

		private bool _isLocked;

		private bool _checked;

		private Image _image;

		private Toggle.ToggleEvent _onToggle;

		private void Awake()
		{
		}

		public void Initialize(bool isChecked, bool isLocked, UnityAction<bool> toggleEvent = null)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public bool IsChecked()
		{
			return false;
		}

		private void SetChecked(bool value)
		{
		}
	}
}
