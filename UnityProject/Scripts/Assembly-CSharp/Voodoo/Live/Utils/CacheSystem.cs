using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Voodoo.Live.Utils
{
	public class CacheSystem
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteCache_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CacheSystem _003C_003E4__this;

			public string data;

			private string _003CtempFilePath_003E5__2;

			private StreamWriter _003Cwriter_003E5__3;

			private object _003C_003E7__wrap3;

			private int _003C_003E7__wrap4;

			private TaskAwaiter _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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

		private readonly string _fileName;

		private readonly string _filePath;

		public CacheSystem(string fileName, string buildCache = "")
		{
		}

		public string ReadCache()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteCache_003Ed__4))]
		private Task WriteCache(string data)
		{
			return null;
		}

		public void UpdateCacheIfNeeded(string newData)
		{
		}

		private string GetChecksum(string inputData)
		{
			return null;
		}
	}
}
