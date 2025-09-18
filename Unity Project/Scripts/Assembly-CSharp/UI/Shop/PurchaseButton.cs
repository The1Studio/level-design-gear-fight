using System;
using Data.Operations;
using Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Shop
{
	[RequireComponent(typeof(Button))]
	public class PurchaseButton : MonoBehaviour
	{
		[SerializeField]
		private TransactionSO _settings;

		[SerializeField]
		private TextMeshProUGUI _priceText;

		[SerializeField]
		private GameObject _purchasableRoot;

		[SerializeField]
		private GameObject _notPurchasableRoot;

		[SerializeField]
		private TextMeshProUGUI _timerText;

		private ITransaction _transaction;

		private Action<bool> _onComplete;

		private bool _hasRegistered;

		[field: SerializeField]
		public TransactionLocation TransactionLocation { get; private set; }

		[field: SerializeField]
		public Button Button { get; private set; }

		public bool ForceBlockPurchase { get; set; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void RefreshTimerVisual()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void SafeRegister()
		{
		}

		private void SafeUnregister()
		{
		}

		private void Purchase()
		{
		}

		private void OnPurchasableChanged(bool purchasable)
		{
		}

		public void Initialize(ITransaction transaction, Action<bool> onTransactionSucceed)
		{
		}

		public void RegisterOnComplete(Action<bool> onTransactionComplete)
		{
		}

		public void UnregisterOnComplete(Action<bool> onTransactionComplete)
		{
		}
	}
}
