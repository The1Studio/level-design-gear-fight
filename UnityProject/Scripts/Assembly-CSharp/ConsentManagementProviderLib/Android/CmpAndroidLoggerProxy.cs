using UnityEngine;

namespace ConsentManagementProviderLib.Android
{
	public class CmpAndroidLoggerProxy : AndroidJavaProxy
	{
		private static readonly string NativeJavaInterfaceName;

		public CmpAndroidLoggerProxy()
			: base((string)null)
		{
		}

		private void error(AndroidJavaObject RuntimeException)
		{
		}

		private void e(string tag, string msg)
		{
		}

		private void req(string tag, string url, string type, string body)
		{
		}

		private void res(string tag, string msg, string status, string body)
		{
		}

		private void i(string tag, string msg)
		{
		}

		private void d(string tag, string msg)
		{
		}

		private void v(string tag, string msg)
		{
		}

		private void computation(string tag, string msg)
		{
		}

		private void computation(string tag, string msg, AndroidJavaObject? json)
		{
		}

		private void nativeMessageAction(string tag, string msg, AndroidJavaObject? json)
		{
		}

		private void webAppAction(string tag, string msg, AndroidJavaObject? json)
		{
		}

		private void clientEvent(string _event, string msg, string content)
		{
		}

		private void pm(string tag, string url, string type, string? _params)
		{
		}

		private void flm(string tag, string url, string type, AndroidJavaObject json)
		{
		}
	}
}
