using System.Collections.Generic;
using UnityEngine;

namespace Items
{
	public class RarityManager : MonoBehaviour
	{
		private static RarityManager _instance;

		[SerializeField]
		private RaritySO[] _rarities;

		private Dictionary<string, RaritySO> _raritiesDict;

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		public static RaritySO GetRarity(string id)
		{
			return null;
		}
	}
}
