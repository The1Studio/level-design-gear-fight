namespace Nakama
{
	public interface ILogger
	{
		void DebugFormat(string format, params object[] args);

		void ErrorFormat(string format, params object[] args);

		void InfoFormat(string format, params object[] args);

		void WarnFormat(string format, params object[] args);
	}
}
