namespace Voodoo.Nakama.Storage
{
	public interface INakamaStorageEncryptionHandler
	{
		string Decrypt(string data);

		string Encrypt(string data);
	}
}
