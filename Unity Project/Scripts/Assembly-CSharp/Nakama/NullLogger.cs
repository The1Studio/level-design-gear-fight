namespace Nakama
{
	public class NullLogger : ILogger
	{
		public static readonly ILogger Instance;

		private NullLogger()
		{
		}

		public void DebugFormat(string format, params object[] args)
		{
		}

		public void ErrorFormat(string format, params object[] args)
		{
		}

		public void InfoFormat(string format, params object[] args)
		{
		}

		public void WarnFormat(string format, params object[] args)
		{
		}
	}
}
