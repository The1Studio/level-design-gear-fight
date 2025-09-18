using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NakamaHttp;
using Voodoo.Nakama.Server;

namespace Voodoo.Nakama.AuthProviders
{
	public class GooglePlayAuthProvider : NakamaAuthProvider
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticate_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NakamaHttpClient> _003C_003Et__builder;

			public GooglePlayAuthProvider _003C_003E4__this;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private NakamaHttpClient _003Cc_003E5__2;

			private TaskAwaiter<Session> _003C_003Eu__3;

			private TaskAwaiter _003C_003Eu__4;

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
		private struct _003CEnsureLogin_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			private TaskAwaiter<bool> _003C_003Eu__1;

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
		private struct _003CLink_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkResult> _003C_003Et__builder;

			public GooglePlayAuthProvider _003C_003E4__this;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private TaskAwaiter<Empty> _003C_003Eu__3;

			private TaskAwaiter _003C_003Eu__4;

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
		private struct _003CUnlink_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public GooglePlayAuthProvider _003C_003E4__this;

			private TaskAwaiter<Empty> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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

		public GooglePlayAuthProvider(NakamaServer nakama)
			: base(null)
		{
		}

		public override void Init()
		{
		}

		[AsyncStateMachine(typeof(_003CLink_003Ed__2))]
		public override Task<LinkResult> Link()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlink_003Ed__3))]
		public override Task<bool> Unlink()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticate_003Ed__4))]
		public override Task<NakamaHttpClient> Authenticate()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CEnsureLogin_003Ed__5))]
		private Task<bool> EnsureLogin()
		{
			return null;
		}

		private Task<string> GetServerToken()
		{
			return null;
		}
	}
}
