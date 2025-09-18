using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Nakama
{
	public class GZipContent : HttpContent
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSerializeToStreamAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public System.IO.Stream stream;

			public GZipContent _003C_003E4__this;

			private GZipStream _003Cgzip_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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

		private readonly HttpContent _content;

		public GZipContent(HttpContent content)
		{
		}

		[AsyncStateMachine(typeof(_003CSerializeToStreamAsync_003Ed__2))]
		protected override Task SerializeToStreamAsync(System.IO.Stream stream, TransportContext context)
		{
			return null;
		}

		protected override bool TryComputeLength(out long length)
		{
			length = default(long);
			return false;
		}
	}
}
