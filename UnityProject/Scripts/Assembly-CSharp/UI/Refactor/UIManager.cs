using Core.UI;
using UnityEngine;

namespace UI.Refactor
{
	public class UIManager : MonoBehaviour
	{
		private static UIManager instance;

		[SerializeField]
		[Header("Links")]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private ScreenSystem _screenSystem;

		[SerializeField]
		private PopupSystem _popupSystem;

		[SerializeField]
		private GameObject _cheatOverlay;

		public static UIManager Instance => null;

		public PopupSystem PopupSystem => null;

		public static Vector3 ScreenCenter { get; private set; }

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public void SetCanvasGroupAlpha(float alpha)
		{
		}

		public T Open<T>() where T : Core.UI.Screen
		{
			return null;
		}

		public T GetScreen<T>() where T : Core.UI.Screen
		{
			return null;
		}

		public bool IsScreenOpened<T>() where T : Core.UI.Screen
		{
			return false;
		}

		public void EnableCheatOverlay(bool enable)
		{
		}
	}
}
