using System;
using TMPro;
using UnityEngine;

namespace Items
{
	public class DropView : MonoBehaviour, IViewRoot
	{
		[SerializeField]
		private ItemView _itemView;

		[SerializeField]
		[Header("Amount")]
		private bool _localizeAmount;

		[SerializeField]
		private string _amountFormating;

		[SerializeField]
		private string _multipleAmountFormating;

		[SerializeField]
		private TextMeshProUGUI _amount;

		[SerializeField]
		[Header("DropRate")]
		private string _dropRateFormating;

		[SerializeField]
		private TextMeshProUGUI _dropRate;

		public RectTransform Root => null;

		public ItemView ItemView => null;

		private void NormalAmountFormatting(DropInfos dropInfos)
		{
		}

		private void MultiAmountFormatting(DropInfos dropInfos)
		{
		}

		public void SetDropRateActive(bool active)
		{
		}

		public void SetAmountActive(bool active)
		{
		}

		public void SetDropRate(string txt)
		{
		}

		public void SetAmount(string txt)
		{
		}

		public virtual void Initialize(DropInfos dropInfos, Action<ItemView> onSelect = null)
		{
		}
	}
}
