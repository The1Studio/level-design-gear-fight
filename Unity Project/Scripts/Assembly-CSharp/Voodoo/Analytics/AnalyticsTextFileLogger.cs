using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Voodoo.Analytics
{
	internal static class AnalyticsTextFileLogger
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLogToText_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public HttpResponseMessage responseMessage;

			private List<string> _003CstringsToWrite_003E5__2;

			private List<string> _003C_003E7__wrap2;

			private TaskAwaiter<string> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static string _apiRequestResponseLoggerPath;

		private static bool _isDebugMode;

		private const string TAG = "Analytics - TextLogger";

		private const string BEGIN_API = "-----BEGIN API LOG-----";

		private const string END_API = "-----END API LOG------";

		private const string BEGIN_REQUEST_HEADER = "-----BEGIN REQUEST HEADER-----";

		private const string END_REQUEST_HEADER = "-----END REQUEST HEADER-----";

		private const string BEGIN_REQUEST_BODY = "-----BEGIN REQUEST BODY-----";

		private const string END_REQUEST_BODY = "-----END REQUEST BODY-----";

		private const string BEGIN_RESPONSE_BODY = "-----BEGIN RESPONSE BODY-----";

		private const string END_RESPONSE_BODY = "-----END RESPONSE BODY-----";

		private const string BEGIN_RESPONSE_STATUS = "-----BEGIN RESPONSE STATUS-----";

		private const string END_RESPONSE_STATUS = "-----END RESPONSE STATUS-----";

		private const string BEGIN_EXCEPTION = "-----BEGIN API EXCEPTION-----";

		private const string END_EXCEPTION = "-----END API EXCEPTION-----";

		private const string FILE_NAME = "analytics_export_logs.txt";

		internal static void ConfigureAutomatedTextLogger(string path, bool isDebugMode)
		{
		}

		private static void WriteRequestHeader(List<string> stringToWrite, string requestHeaderString)
		{
		}

		private static void WriteRequestBody(List<string> stringToWrite, string requestBodyString)
		{
		}

		private static void WriteResponseStatusCode(List<string> stringToWrite, HttpStatusCode statusCode)
		{
		}

		private static void WriteResponseBody(List<string> stringToWrite, string responseBody)
		{
		}

		[AsyncStateMachine(typeof(_003CLogToText_003Ed__21))]
		public static void LogToText(HttpResponseMessage responseMessage)
		{
		}

		public static void LogExceptionToText(Exception exception)
		{
		}

		private static void WriteAnalyticsLogsToFile(List<string> stringsToWrite)
		{
		}
	}
}
