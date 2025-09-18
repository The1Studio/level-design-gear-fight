using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
	public class PopupSystem : MonoBehaviour
	{
		[SerializeField]
		private PopupDictionnarySO _popupDictionnary;

		[SerializeField]
		private RectTransform _root;

		[SerializeField]
		private Button _backdrop;

		private List<PopupData> _pendingPopups;

		private List<PopupData> _pendingPriorityPopups;

		private List<Popup> _activePopups;

		private Dictionary<string, Popup> _reusablePopups;

		private void ResetBackdrop()
		{
		}

		private void SetupBackdrop(Popup popup)
		{
		}

		internal Popup Build(PopupData popupData)
		{
			return null;
		}

		private void TryOpenNextPriorityPopup()
		{
		}

		private void Update()
		{
		}

		public void Close(Popup popup)
		{
		}

		public void Close(string id)
		{
		}

		internal void Cancel(PopupData popup)
		{
		}

		public void Cancel(string id)
		{
		}

		internal void HandleExternalDestroy(Popup popup)
		{
		}

		public void Destroy(string id)
		{
		}

		public PopupBuilder<T> Request<T>(T popupPrefab, string id) where T : Popup
		{
			return null;
		}

		public PopupBuilder<T> Request<T>(string id) where T : Popup
		{
			return null;
		}

		public bool TryGetActive<T>(out T popup) where T : Popup
		{
			popup = null;
			return false;
		}
	}
}
