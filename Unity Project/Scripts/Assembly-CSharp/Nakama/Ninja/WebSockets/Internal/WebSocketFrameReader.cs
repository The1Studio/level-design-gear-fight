using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets.Internal
{
	internal static class WebSocketFrameReader
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadAsync_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<WebSocketFrame> _003C_003Et__builder;

			public System.IO.Stream fromStream;

			public CancellationToken cancellationToken;

			public ArraySegment<byte> intoBuffer;

			private ArraySegment<byte> _003CsmallBuffer_003E5__2;

			private bool _003CisFinBitSet_003E5__3;

			private WebSocketOpCode _003CopCode_003E5__4;

			private bool _003CisMaskBitSet_003E5__5;

			private int _003Ccount_003E5__6;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<uint> _003C_003Eu__2;

			private ArraySegment<byte> _003CmaskKey_003E5__7;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadLength_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<uint> _003C_003Et__builder;

			public byte byte2;

			public System.IO.Stream fromStream;

			public ArraySegment<byte> smallBuffer;

			public CancellationToken cancellationToken;

			private TaskAwaiter<ushort> _003C_003Eu__1;

			private TaskAwaiter<ulong> _003C_003Eu__2;

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

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__0))]
		public static Task<WebSocketFrame> ReadAsync(System.IO.Stream fromStream, ArraySegment<byte> intoBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		private static WebSocketFrame DecodeCloseFrame(bool isFinBitSet, WebSocketOpCode opCode, int count, ArraySegment<byte> buffer)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadLength_003Ed__2))]
		private static Task<uint> ReadLength(byte byte2, ArraySegment<byte> smallBuffer, System.IO.Stream fromStream, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
