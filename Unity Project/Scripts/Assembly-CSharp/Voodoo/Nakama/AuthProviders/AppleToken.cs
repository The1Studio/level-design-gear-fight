namespace Voodoo.Nakama.AuthProviders
{
	public class AppleToken
	{
		public string iss;

		public string aud;

		public long exp;

		public long iat;

		public string sub;

		public string c_hash;

		public long auth_time;

		public bool nonce_supported;

		public int real_user_status;
	}
}
