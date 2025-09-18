using System;
using TMPro;
using UnityEngine;

namespace Items
{
	public class RewardView : MonoBehaviour, IViewRoot
	{
		[SerializeField]
		private ItemView _itemView;

		[Header("Amount")]
		[SerializeField]
		private string _amountFormating;

		[SerializeField]
		private TextMeshProUGUI _amount;

		public RectTransform Root => null;

		public ItemView ItemView => null;

		public void SetAmount(string txt)
		{
		}

		public void SetAmountActive(bool value)
		{
		}

		public virtual void Initialize(Reward reward, Action<ItemView> onSelect = null)
		{
		}
	}
}
