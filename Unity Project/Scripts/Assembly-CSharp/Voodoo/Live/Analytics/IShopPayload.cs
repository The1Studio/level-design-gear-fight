using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public interface IShopPayload
	{
		string ShopId { get; }

		string ShopName { get; }

		Dictionary<string, object> GetParameters();
	}
}
