using System;
using System.Collections.Generic;
using Items;
using UnityEngine;

namespace UI.Shop
{
	[Serializable]
	public class RewardTransactionResult : ITransactionResult
	{
		[SerializeField]
		private RewardSO _rewards;

		[SerializeField]
		private int _amount;

		public List<DropInfos> GetDrops()
		{
			return null;
		}

		public void OnTransactionCompleted(TransactionLocation location)
		{
		}
	}
}
