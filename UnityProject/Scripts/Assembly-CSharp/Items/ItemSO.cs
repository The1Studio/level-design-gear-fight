using UnityEngine;
using Voodoo.Sauce.Internal.Analytics;

namespace Items
{
	public abstract class ItemSO : ScriptableObject
	{
		public ItemNames Id;

		public Types Type;

		public ItemType SubType;

		public Sprite Icon;

		[SerializeField]
		private string _localizationKey;

		public RaritySO Rarity;

		public string Name => null;

		public virtual bool Stackable => false;

		public virtual double GetBalance()
		{
			return 0.0;
		}
	}
}
