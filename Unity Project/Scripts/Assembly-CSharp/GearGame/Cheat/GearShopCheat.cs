using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Cheat
{
	public class GearShopCheat : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private RectTransform _root;

		[SerializeField]
		private Vector2 _openPosition;

		[SerializeField]
		private Vector2 _closePosition;

		[SerializeField]
		private GearSlotCheat _slotPrefab;

		[SerializeField]
		private ScrollRect _scrollRect;

		private GearSlotCheat[] _slots;

		private GameObject _gearHolder;

		private bool _opened;

		public void Start()
		{
		}

		private void Init()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnOpenScroll()
		{
		}

		private void SpawnGears()
		{
		}
	}
}
