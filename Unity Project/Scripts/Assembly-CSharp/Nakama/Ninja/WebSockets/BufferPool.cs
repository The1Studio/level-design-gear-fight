using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Nakama.Ninja.WebSockets
{
	public class BufferPool : IBufferPool
	{
		protected class PublicBufferMemoryStream : MemoryStream
		{
			private readonly BufferPool _bufferPoolInternal;

			private byte[] _buffer;

			private MemoryStream _ms;

			public override long Length => 0L;

			public override bool CanRead => false;

			public override bool CanSeek => false;

			public override bool CanTimeout => false;

			public override bool CanWrite => false;

			public override int Capacity
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public override long Position
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public override int ReadTimeout
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public override int WriteTimeout
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public PublicBufferMemoryStream(byte[] buffer, BufferPool bufferPool)
			{
			}

			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				return null;
			}

			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				return null;
			}

			public override void Close()
			{
			}

			public override Task CopyToAsync(System.IO.Stream destination, int bufferSize, CancellationToken cancellationToken)
			{
				return null;
			}

			public override int EndRead(IAsyncResult asyncResult)
			{
				return 0;
			}

			public override void EndWrite(IAsyncResult asyncResult)
			{
			}

			public override void Flush()
			{
			}

			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				return null;
			}

			public override byte[] GetBuffer()
			{
				return null;
			}

			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			private void EnlargeBufferIfRequired(int count)
			{
			}

			public override void WriteByte(byte value)
			{
			}

			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				return null;
			}

			public override object InitializeLifetimeService()
			{
				return null;
			}

			public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				return null;
			}

			public override int ReadByte()
			{
				return 0;
			}

			public override long Seek(long offset, SeekOrigin loc)
			{
				return 0L;
			}

			public override void SetLength(long value)
			{
			}

			public override byte[] ToArray()
			{
				return null;
			}

			public override bool TryGetBuffer(out ArraySegment<byte> buffer)
			{
				buffer = default(ArraySegment<byte>);
				return false;
			}

			public override void WriteTo(System.IO.Stream stream)
			{
			}
		}

		private const int DEFAULT_BUFFER_SIZE = 16384;

		private readonly ConcurrentStack<byte[]> _bufferPoolStack;

		private readonly int _bufferSize;

		public BufferPool()
		{
		}

		public BufferPool(int bufferSize)
		{
		}

		public MemoryStream GetBuffer()
		{
			return null;
		}

		protected void ReturnBuffer(byte[] buffer)
		{
		}
	}
}
