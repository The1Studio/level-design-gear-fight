using Voodoo.Live.Shop.Data;

namespace Voodoo.Live
{
	public interface IShopClient : IClient
	{
		Product GetProductByIapId(string iapId);
	}
}
