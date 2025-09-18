using Data.Operations;
using UnityEngine;

namespace UI.Shop
{
	[CreateAssetMenu(menuName = "Shop/Transaction")]
	public class TransactionSO : ScriptableObject
	{
		[SerializeReference]
		public ITransaction Transaction;

		[SerializeField]
		private string _failedPurchaseLocKey;

		[SerializeReference]
		public ITransactionResult TransactionResult;

		public string GetFailedPurchaseLocalizedText()
		{
			return null;
		}
	}
}
