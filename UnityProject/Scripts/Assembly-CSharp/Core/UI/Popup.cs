using UnityEngine;

namespace Core.UI
{
	public class Popup : MonoBehaviour
	{
		internal PopupData Data { get; private set; }

		internal void Open(PopupData data)
		{
		}

		protected virtual void OnOpen()
		{
		}

		protected virtual void OnClose()
		{
		}

		public virtual void ResetState()
		{
		}

		public void Close()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public static void Close(string id)
		{
		}

		public static void Cancel(string id)
		{
		}

		public static void Destroy(string id)
		{
		}

		public static PopupBuilder<T> New<T>(T popupPrefab, string id = "") where T : Popup
		{
			return null;
		}

		public static PopupBuilder<T> New<T>(string id = "") where T : Popup
		{
			return null;
		}

		public static bool TryGetActive<T>(out T popup) where T : Popup
		{
			popup = null;
			return false;
		}
	}
}
