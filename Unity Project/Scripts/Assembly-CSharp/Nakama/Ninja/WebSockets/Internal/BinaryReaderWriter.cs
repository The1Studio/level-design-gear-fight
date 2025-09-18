using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets.Internal
{
	public class BinaryReaderWriter
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadExactly_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public int length;

			public ArraySegment<byte> buffer;

			public System.IO.Stream stream;

			public CancellationToken cancellationToken;

			private int _003Coffset_003E5__2;

			private TaskAwaiter<int> _003C_003Eu__1;

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
		private struct _003CReadLongExactly_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<long> _003C_003Et__builder;

			public System.IO.Stream stream;

			public ArraySegment<byte> buffer;

			public CancellationToken cancellationToken;

			public bool isLittleEndian;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadULongExactly_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ulong> _003C_003Et__builder;

			public System.IO.Stream stream;

			public ArraySegment<byte> buffer;

			public CancellationToken cancellationToken;

			public bool isLittleEndian;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadUShortExactly_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ushort> _003C_003Et__builder;

			public System.IO.Stream stream;

			public ArraySegment<byte> buffer;

			public CancellationToken cancellationToken;

			public bool isLittleEndian;

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

		[AsyncStateMachine(typeof(_003CReadExactly_003Ed__0))]
		public static Task ReadExactly(int length, System.IO.Stream stream, ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadUShortExactly_003Ed__1))]
		public static Task<ushort> ReadUShortExactly(System.IO.Stream stream, bool isLittleEndian, ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadULongExactly_003Ed__2))]
		public static Task<ulong> ReadULongExactly(System.IO.Stream stream, bool isLittleEndian, ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadLongExactly_003Ed__3))]
		public static Task<long> ReadLongExactly(System.IO.Stream stream, bool isLittleEndian, ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		public static void WriteInt(int value, System.IO.Stream stream, bool isLittleEndian)
		{
		}

		public static void WriteULong(ulong value, System.IO.Stream stream, bool isLittleEndian)
		{
		}

		public static void WriteLong(long value, System.IO.Stream stream, bool isLittleEndian)
		{
		}

		public static void WriteUShort(ushort value, System.IO.Stream stream, bool isLittleEndian)
		{
		}
	}
}
