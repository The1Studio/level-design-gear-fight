using System;
using Voodoo.Live.Offers;
using Voodoo.Live.Utils;

namespace Voodoo.Live
{
	public class TransactionRegistry
	{
		private const string _cacheFileName = "voodoolive_local_transactions.json";

		private CacheSystem _cache;

		private IFeatureClient _client;

		private TransactionCollection _transactions;

		private Func<Transaction, bool> rewardingMethod;

		public TransactionRegistry(Func<Transaction, bool> rewardingMethod)
		{
		}

		public void Initialize(IFeatureClient client)
		{
		}

		public bool IsPurchaseUpdate(string status, IFeature feature)
		{
			return false;
		}

		private void OnStatusChanged(string status, IFeature feature)
		{
		}

		private void CreateTransaction(IFeature feature)
		{
		}

		public void RewardTransaction(Transaction transaction)
		{
		}

		private void PurchaseFailed(Transaction transaction)
		{
		}

		public Transaction GetTransaction(string featureId)
		{
			return null;
		}

		public Transaction GetTransactionBySKU(string productId)
		{
			return null;
		}
	}
}
