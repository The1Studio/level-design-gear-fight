using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AppleAuth;
using AppleAuth.Interfaces;
using NakamaHttp;
using Voodoo.Nakama.Server;

namespace Voodoo.Nakama.AuthProviders
{
	public class AppleAuthProvider : NakamaAuthProvider, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticate_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<NakamaHttpClient> _003C_003Et__builder;

			public AppleAuthProvider _003C_003E4__this;

			private TaskAwaiter<AppleSignInStatus> _003C_003Eu__1;

			private NakamaHttpClient _003Cc_003E5__2;

			private TaskAwaiter<Session> _003C_003Eu__2;

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
		private struct _003CCheckLoginState_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AppleSignInStatus> _003C_003Et__builder;

			public AppleAuthProvider _003C_003E4__this;

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
		private struct _003CEnsureLogin_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AppleSignInStatus> _003C_003Et__builder;

			public AppleAuthProvider _003C_003E4__this;

			private TaskAwaiter<AppleSignInStatus> _003C_003Eu__1;

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
		private struct _003CLink_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkResult> _003C_003Et__builder;

			public AppleAuthProvider _003C_003E4__this;

			private TaskAwaiter<AppleSignInStatus> _003C_003Eu__1;

			private TaskAwaiter<Empty> _003C_003Eu__2;

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
		private struct _003CUnlink_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public AppleAuthProvider _003C_003E4__this;

			private TaskAwaiter<Empty> _003C_003Eu__1;

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

		private const string AppleUserIdKey = "AppleUserId";

		private const string AppleTokenKey = "AppleTokenKey";

		private IAppleAuthManager _appleAuthManager;

		private readonly NakamaServer _nakama;

		public AppleAuthProvider(NakamaServer nakama)
			: base(null)
		{
		}

		public override void Init()
		{
		}

		private void OnUpdate()
		{
		}

		[AsyncStateMachine(typeof(_003CLink_003Ed__7))]
		public override Task<LinkResult> Link()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlink_003Ed__8))]
		public override Task<bool> Unlink()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CEnsureLogin_003Ed__9))]
		private Task<AppleSignInStatus> EnsureLogin()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCheckLoginState_003Ed__10))]
		private Task<AppleSignInStatus> CheckLoginState()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticate_003Ed__11))]
		public override Task<NakamaHttpClient> Authenticate()
		{
			return null;
		}

		private Task<bool> CheckCredentialStatusForUserId(string appleUserId)
		{
			return null;
		}

		private Task<AppleSignInStatus> AttemptQuickLogin()
		{
			return null;
		}

		private Task<AppleSignInStatus> SignInWithApple()
		{
			return null;
		}

		private static void SetCredential(IAppleIDCredential appleId)
		{
		}

		public void Dispose()
		{
		}
	}
}
