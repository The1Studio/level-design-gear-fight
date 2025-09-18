using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Items
{
	public class ItemView : MonoBehaviour, IViewRoot
	{
		[SerializeField]
		protected Button _button;

		public Action<ItemView> onSelect;

		[SerializeField]
		protected RectTransform _root;

		[SerializeField]
		protected Image _icon;

		[SerializeField]
		protected Image _background;

		[SerializeField]
		[Header("Name")]
		protected bool _colorName;

		[SerializeField]
		protected bool _addRarity;

		[SerializeField]
		[TextArea]
		protected string _nameFormating;

		[SerializeField]
		private TextMeshProUGUI _name;

		[field: Header("Background")]
		[field: SerializeField]
		public string backgroundId { get; private set; }

		public RectTransform Root => null;

		public Button Button => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Select()
		{
		}

		public void SetIcon(Sprite icon)
		{
		}

		public void SetBackground(Sprite background)
		{
		}

		public void SetName(params string[] values)
		{
		}

		private void Initialize(string name, RaritySO rarity, Sprite icon, Action<ItemView> onSelect)
		{
		}

		public virtual void Initialize(ItemSO item, RaritySO rarity, Sprite icon, Action<ItemView> onSelect = null)
		{
		}

		public void Initialize(ItemSO item, Action<ItemView> onSelect = null)
		{
		}

		public virtual void Initialize(Item item, Action<ItemView> onSelect = null)
		{
		}
	}
}
