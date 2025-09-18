using System;
using Newtonsoft.Json;

namespace Voodoo.Live.Offers
{
	[Serializable]
	public class ItemConfig
	{
		public string Id { get; }

		public string Name { get; }

		public string Description { get; }

		public string Sprite { get; }

		public ItemType Type { get; }

		[JsonConstructor]
		public ItemConfig(string id, string name, string description, string offerImage, ItemType type)
		{
		}
	}
}
