using System.Threading.Tasks;
using NakamaHttp;

namespace Voodoo.Nakama.Server
{
	public abstract class NakamaAuthProvider
	{
		protected readonly NakamaServer Nakama;

		protected NakamaAuthProvider(NakamaServer nakama)
		{
		}

		public abstract void Init();

		public void SetLinked()
		{
		}

		public void SetUnlinked()
		{
		}

		public bool IsLinked()
		{
			return false;
		}

		public abstract Task<LinkResult> Link();

		public abstract Task<bool> Unlink();

		public abstract Task<NakamaHttpClient> Authenticate();
	}
}
