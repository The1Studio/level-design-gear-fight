using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nakama;

namespace NakamaHttp
{
	public class NakamaHttpClient
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddRewardItemsDebug_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AddRewardItemsDebugReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<AddRewardItemsDebugResp> success;

			private TaskAwaiter<AddRewardItemsDebugResp> _003C_003Eu__1;

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
		private struct _003CAddRewardItemsDebugAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AddRewardItemsDebugResp> _003C_003Et__builder;

			public AddRewardItemsDebugReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddUpdateCheckRule_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public UpdateCheckRuleRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<BoolValue> success;

			private TaskAwaiter<BoolValue> _003C_003Eu__1;

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
		private struct _003CAddUpdateCheckRuleAsync_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<BoolValue> _003C_003Et__builder;

			public UpdateCheckRuleRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAssociateVoodooId_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public VoodooId req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<VoodooAccount> success;

			private TaskAwaiter<VoodooAccount> _003C_003Eu__1;

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
		private struct _003CAssociateVoodooIdAsync_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<VoodooAccount> _003C_003Et__builder;

			public VoodooId req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateApple_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateAppleRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateAppleAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateAppleRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateDevice_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateDeviceRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateDeviceAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateDeviceRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateEmail_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateEmailRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateEmailAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateEmailRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateEmailRequestCode_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateEmailRequestCodeRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateEmailRequestCodeAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AuthenticateEmailRequestCodeRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateEmailVerifyCode_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateEmailVerifyCodeRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateEmailVerifyCodeAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateEmailVerifyCodeRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateFacebook_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateFacebookRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateFacebookAsync_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateFacebookRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateFacebookInstantGame_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateFacebookInstantGameRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateFacebookInstantGameAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateFacebookInstantGameRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateGameCenter_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateGameCenterRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateGameCenterAsync_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateGameCenterRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthenticateGoogle_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AuthenticateGoogleRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CAuthenticateGoogleAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public AuthenticateGoogleRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClaimGifts_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ClaimGiftsReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<ClaimGiftsResp> success;

			private TaskAwaiter<ClaimGiftsResp> _003C_003Eu__1;

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
		private struct _003CClaimGiftsAsync_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ClaimGiftsResp> _003C_003Et__builder;

			public ClaimGiftsReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClearAllUpdateCheckRules_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<BoolValue> success;

			private TaskAwaiter<BoolValue> _003C_003Eu__1;

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
		private struct _003CClearAllUpdateCheckRulesAsync_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<BoolValue> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCodeGenEcho_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public CodegenEchoMessage req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<CodegenEchoMessage> success;

			private TaskAwaiter<CodegenEchoMessage> _003C_003Eu__1;

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
		private struct _003CCodeGenEchoAsync_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CodegenEchoMessage> _003C_003Et__builder;

			public CodegenEchoMessage req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCodegen_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GenericRpcMessageContainer req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCodegenAsync_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public GenericRpcMessageContainer req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCollectList_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public CollectListReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<CollectListResp> success;

			private TaskAwaiter<CollectListResp> _003C_003Eu__1;

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
		private struct _003CCollectListAsync_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CollectListResp> _003C_003Et__builder;

			public CollectListReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDebugCreateLeaderboard_003Ed__181 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public CreateLeaderboard req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Leaderboard> success;

			private TaskAwaiter<Leaderboard> _003C_003Eu__1;

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
		private struct _003CDebugCreateLeaderboardAsync_003Ed__180 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Leaderboard> _003C_003Et__builder;

			public CreateLeaderboard req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteAccount_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public DeleteAccountRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<DeleteAccountResponse> success;

			private TaskAwaiter<DeleteAccountResponse> _003C_003Eu__1;

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
		private struct _003CDeleteAccountAsync_003Ed__58 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<DeleteAccountResponse> _003C_003Et__builder;

			public DeleteAccountRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteFeatureRound_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public FeatureRoundDeleteReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<FeatureRoundsResp> success;

			private TaskAwaiter<FeatureRoundsResp> _003C_003Eu__1;

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
		private struct _003CDeleteFeatureRoundAsync_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<FeatureRoundsResp> _003C_003Et__builder;

			public FeatureRoundDeleteReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteFeatureRounds_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public FeatureId req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteFeatureRoundsAsync_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public FeatureId req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteLeaderboardRecord_003Ed__183 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public DeleteLeaderboardRecordRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteLeaderboardRecordAsync_003Ed__182 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public DeleteLeaderboardRecordRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteRewardItemsDebug_003Ed__65 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public DeleteRewardItemsDebugReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<DeleteRewardItemsDebugResp> success;

			private TaskAwaiter<DeleteRewardItemsDebugResp> _003C_003Eu__1;

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
		private struct _003CDeleteRewardItemsDebugAsync_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<DeleteRewardItemsDebugResp> _003C_003Et__builder;

			public DeleteRewardItemsDebugReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteStorageObjects_003Ed__67 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public DeleteStorageObjectsRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteStorageObjectsAsync_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public DeleteStorageObjectsRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CEcho_003Ed__69 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<EchoResponse> success;

			private TaskAwaiter<EchoResponse> _003C_003Eu__1;

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
		private struct _003CEchoAsync_003Ed__68 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<EchoResponse> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAccount_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Account> success;

			private TaskAwaiter<Account> _003C_003Eu__1;

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
		private struct _003CGetAccountAsync_003Ed__70 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Account> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetCompetitiveEventsMinVersion_003Ed__73 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetCompetitiveEventsMinVersionReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetCompetitiveEventsMinVersionResp> success;

			private TaskAwaiter<GetCompetitiveEventsMinVersionResp> _003C_003Eu__1;

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
		private struct _003CGetCompetitiveEventsMinVersionAsync_003Ed__72 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetCompetitiveEventsMinVersionResp> _003C_003Et__builder;

			public GetCompetitiveEventsMinVersionReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetNotFinishedFeatureRounds_003Ed__75 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<FeatureRoundsResp> success;

			private TaskAwaiter<FeatureRoundsResp> _003C_003Eu__1;

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
		private struct _003CGetNotFinishedFeatureRoundsAsync_003Ed__74 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<FeatureRoundsResp> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPendingGifts_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetPendingGiftsReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetPendingGiftsResp> success;

			private TaskAwaiter<GetPendingGiftsResp> _003C_003Eu__1;

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
		private struct _003CGetPendingGiftsAsync_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetPendingGiftsResp> _003C_003Et__builder;

			public GetPendingGiftsReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPlayerProfile_003Ed__187 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetPlayerProfileReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetPlayerProfileResp> success;

			private TaskAwaiter<GetPlayerProfileResp> _003C_003Eu__1;

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
		private struct _003CGetPlayerProfileAsync_003Ed__186 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetPlayerProfileResp> _003C_003Et__builder;

			public GetPlayerProfileReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPlayerProfiles_003Ed__189 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetPlayerProfilesReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetPlayerProfilesResp> success;

			private TaskAwaiter<GetPlayerProfilesResp> _003C_003Eu__1;

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
		private struct _003CGetPlayerProfilesAsync_003Ed__188 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetPlayerProfilesResp> _003C_003Et__builder;

			public GetPlayerProfilesReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPlayerProfilesWithFallback_003Ed__191 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetPlayerProfilesReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetPlayerProfilesResp> success;

			private TaskAwaiter<GetPlayerProfilesResp> _003C_003Eu__1;

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
		private struct _003CGetPlayerProfilesWithFallbackAsync_003Ed__190 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetPlayerProfilesResp> _003C_003Et__builder;

			public GetPlayerProfilesReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetScheduledFeatureRounds_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<FeatureRoundsResp> success;

			private TaskAwaiter<FeatureRoundsResp> _003C_003Eu__1;

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
		private struct _003CGetScheduledFeatureRoundsAsync_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<FeatureRoundsResp> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetUserClientAttributes_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetUserClientAttributesReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetUserClientAttributesResp> success;

			private TaskAwaiter<GetUserClientAttributesResp> _003C_003Eu__1;

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
		private struct _003CGetUserClientAttributesAsync_003Ed__80 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetUserClientAttributesResp> _003C_003Et__builder;

			public GetUserClientAttributesReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetVoodooTuneConfig_003Ed__83 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetVoodooTuneConfigReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetVoodooTuneConfigResp> success;

			private TaskAwaiter<GetVoodooTuneConfigResp> _003C_003Eu__1;

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
		private struct _003CGetVoodooTuneConfigAsync_003Ed__82 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetVoodooTuneConfigResp> _003C_003Et__builder;

			public GetVoodooTuneConfigReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetVoodooTuneConfigWithFallback_003Ed__85 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public GetVoodooTuneConfigReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<GetVoodooTuneConfigResp> success;

			private TaskAwaiter<GetVoodooTuneConfigResp> _003C_003Eu__1;

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
		private struct _003CGetVoodooTuneConfigWithFallbackAsync_003Ed__84 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetVoodooTuneConfigResp> _003C_003Et__builder;

			public GetVoodooTuneConfigReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CImportFacebookFriends_003Ed__87 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ImportFacebookFriendsRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CImportFacebookFriendsAsync_003Ed__86 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public ImportFacebookFriendsRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvitationsAccept_003Ed__89 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public InvitationsAcceptReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<InvitationsAcceptResp> success;

			private TaskAwaiter<InvitationsAcceptResp> _003C_003Eu__1;

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
		private struct _003CInvitationsAcceptAsync_003Ed__88 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InvitationsAcceptResp> _003C_003Et__builder;

			public InvitationsAcceptReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvitationsAcceptDebug_003Ed__91 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public InvitationsAcceptDebugReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<InvitationsAcceptDebugResp> success;

			private TaskAwaiter<InvitationsAcceptDebugResp> _003C_003Eu__1;

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
		private struct _003CInvitationsAcceptDebugAsync_003Ed__90 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InvitationsAcceptDebugResp> _003C_003Et__builder;

			public InvitationsAcceptDebugReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvitationsSync_003Ed__93 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public InvitationsSyncReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<InvitationsSyncResp> success;

			private TaskAwaiter<InvitationsSyncResp> _003C_003Eu__1;

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
		private struct _003CInvitationsSyncAsync_003Ed__92 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<InvitationsSyncResp> _003C_003Et__builder;

			public InvitationsSyncReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLeaderboardDeleteOwnersOlderThan_003Ed__185 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public LeaderboardCleanupRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<LeaderboardCleanupResponse> success;

			private TaskAwaiter<LeaderboardCleanupResponse> _003C_003Eu__1;

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
		private struct _003CLeaderboardDeleteOwnersOlderThanAsync_003Ed__184 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardCleanupResponse> _003C_003Et__builder;

			public LeaderboardCleanupRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkApple_003Ed__95 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountApple req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkAppleAsync_003Ed__94 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountApple req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkDevice_003Ed__97 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountDevice req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkDeviceAsync_003Ed__96 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountDevice req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkEmail_003Ed__99 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountEmail req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkEmailAsync_003Ed__98 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountEmail req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkEmailRequestCode_003Ed__101 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public LinkEmailRequestCodeRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkEmailRequestCodeAsync_003Ed__100 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public LinkEmailRequestCodeRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkEmailVerifyCode_003Ed__103 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public LinkEmailVerifyCodeRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkEmailVerifyCodeAsync_003Ed__102 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public LinkEmailVerifyCodeRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkFacebook_003Ed__105 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public LinkFacebookRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkFacebookAsync_003Ed__104 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public LinkFacebookRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkFacebookInstantGame_003Ed__107 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountFacebookInstantGame req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkFacebookInstantGameAsync_003Ed__106 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountFacebookInstantGame req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkGameCenter_003Ed__109 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountGameCenter req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkGameCenterAsync_003Ed__108 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountGameCenter req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkGoogle_003Ed__111 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountGoogle req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLinkGoogleAsync_003Ed__110 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountGoogle req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CListChannelMessages_003Ed__113 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ListChannelMessagesRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<ChannelMessageList> success;

			private TaskAwaiter<ChannelMessageList> _003C_003Eu__1;

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
		private struct _003CListChannelMessagesAsync_003Ed__112 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ChannelMessageList> _003C_003Et__builder;

			public ListChannelMessagesRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CListLeaderboardPlayerDataRecords_003Ed__171 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ListLeaderboardRecordsRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<LeaderboardPlayerDataRecordList> success;

			private TaskAwaiter<LeaderboardPlayerDataRecordList> _003C_003Eu__1;

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
		private struct _003CListLeaderboardPlayerDataRecordsAroundOwner_003Ed__173 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ListLeaderboardRecordsAroundOwnerRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<LeaderboardPlayerDataRecordList> success;

			private TaskAwaiter<LeaderboardPlayerDataRecordList> _003C_003Eu__1;

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
		private struct _003CListLeaderboardPlayerDataRecordsAroundOwnerAsync_003Ed__172 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardPlayerDataRecordList> _003C_003Et__builder;

			public ListLeaderboardRecordsAroundOwnerRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CListLeaderboardPlayerDataRecordsAsync_003Ed__170 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardPlayerDataRecordList> _003C_003Et__builder;

			public ListLeaderboardRecordsRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CListLeaderboardRecords_003Ed__175 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ListLeaderboardRecordsRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<LeaderboardRecordList> success;

			private TaskAwaiter<LeaderboardRecordList> _003C_003Eu__1;

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
		private struct _003CListLeaderboardRecordsAroundOwner_003Ed__177 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ListLeaderboardRecordsAroundOwnerRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<LeaderboardRecordList> success;

			private TaskAwaiter<LeaderboardRecordList> _003C_003Eu__1;

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
		private struct _003CListLeaderboardRecordsAroundOwnerAsync_003Ed__176 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardRecordList> _003C_003Et__builder;

			public ListLeaderboardRecordsAroundOwnerRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CListLeaderboardRecordsAsync_003Ed__174 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardRecordList> _003C_003Et__builder;

			public ListLeaderboardRecordsRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CMergeAccountAsync_003Ed__114 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MergeAccountResponse> _003C_003Et__builder;

			public MergeAccountRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COneSignalSendStringNotificationDebug_003Ed__116 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public OneSignalSendStringNotificationDebugRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<OneSignalSendStringNotificationDebugResponse> success;

			private TaskAwaiter<OneSignalSendStringNotificationDebugResponse> _003C_003Eu__1;

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
		private struct _003COneSignalSendStringNotificationDebugAsync_003Ed__115 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<OneSignalSendStringNotificationDebugResponse> _003C_003Et__builder;

			public OneSignalSendStringNotificationDebugRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COneSignalSendTemplateNotificationDebug_003Ed__118 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public OneSignalSendTemplateNotificationDebugRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<OneSignalSendTemplateNotificationDebugResponse> success;

			private TaskAwaiter<OneSignalSendTemplateNotificationDebugResponse> _003C_003Eu__1;

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
		private struct _003COneSignalSendTemplateNotificationDebugAsync_003Ed__117 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<OneSignalSendTemplateNotificationDebugResponse> _003C_003Et__builder;

			public OneSignalSendTemplateNotificationDebugRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadStorageObjects_003Ed__120 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ReadStorageObjectsRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<StorageObjects> success;

			private TaskAwaiter<StorageObjects> _003C_003Eu__1;

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
		private struct _003CReadStorageObjectsAsync_003Ed__119 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StorageObjects> _003C_003Et__builder;

			public ReadStorageObjectsRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadiness_003Ed__122 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReadinessAsync_003Ed__121 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRemoveUpdateCheckRule_003Ed__124 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public UpdateCheckRuleRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<BoolValue> success;

			private TaskAwaiter<BoolValue> _003C_003Eu__1;

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
		private struct _003CRemoveUpdateCheckRuleAsync_003Ed__123 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<BoolValue> _003C_003Et__builder;

			public UpdateCheckRuleRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CResetCompetitiveEventsMinVersion_003Ed__126 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public ResetCompetitiveEventsMinVersionReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<ResetCompetitiveEventsMinVersionResp> success;

			private TaskAwaiter<ResetCompetitiveEventsMinVersionResp> _003C_003Eu__1;

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
		private struct _003CResetCompetitiveEventsMinVersionAsync_003Ed__125 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ResetCompetitiveEventsMinVersionResp> _003C_003Et__builder;

			public ResetCompetitiveEventsMinVersionReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CScheduleFeatureRound_003Ed__128 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public FeatureRoundOptions req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<FeatureRoundsResp> success;

			private TaskAwaiter<FeatureRoundsResp> _003C_003Eu__1;

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
		private struct _003CScheduleFeatureRoundAsync_003Ed__127 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<FeatureRoundsResp> _003C_003Et__builder;

			public FeatureRoundOptions req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendGiftsDebug_003Ed__130 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public SendGiftsDebugReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<SendGiftsDebugResp> success;

			private TaskAwaiter<SendGiftsDebugResp> _003C_003Eu__1;

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
		private struct _003CSendGiftsDebugAsync_003Ed__129 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SendGiftsDebugResp> _003C_003Et__builder;

			public SendGiftsDebugReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CServerTime_003Ed__132 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<ServerTime> success;

			private TaskAwaiter<ServerTime> _003C_003Eu__1;

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
		private struct _003CServerTimeAsync_003Ed__131 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ServerTime> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSessionRefresh_003Ed__134 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public SessionRefreshRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Session> success;

			private TaskAwaiter<Session> _003C_003Eu__1;

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
		private struct _003CSessionRefreshAsync_003Ed__133 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Session> _003C_003Et__builder;

			public SessionRefreshRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetVoodooTuneConfigDebug_003Ed__136 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public SetVoodooTuneConfigReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<SetVoodooTuneConfigResp> success;

			private TaskAwaiter<SetVoodooTuneConfigResp> _003C_003Eu__1;

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
		private struct _003CSetVoodooTuneConfigDebugAsync_003Ed__135 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SetVoodooTuneConfigResp> _003C_003Et__builder;

			public SetVoodooTuneConfigReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSleep_003Ed__138 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public SleepReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSleepAsync_003Ed__137 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public SleepReq req;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStopHammertime_003Ed__140 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStopHammertimeAsync_003Ed__139 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStoryEventList_003Ed__142 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public StoryEventListReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<StoryEventListResp> success;

			private TaskAwaiter<StoryEventListResp> _003C_003Eu__1;

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
		private struct _003CStoryEventListAsync_003Ed__141 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StoryEventListResp> _003C_003Et__builder;

			public StoryEventListReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStoryEventSync_003Ed__144 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public StoryEventSyncReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<StoryEventSyncResp> success;

			private TaskAwaiter<StoryEventSyncResp> _003C_003Eu__1;

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
		private struct _003CStoryEventSyncAsync_003Ed__143 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StoryEventSyncResp> _003C_003Et__builder;

			public StoryEventSyncReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStoryEventVote_003Ed__146 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public StoryEventVoteReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<StoryEventVoteResp> success;

			private TaskAwaiter<StoryEventVoteResp> _003C_003Eu__1;

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
		private struct _003CStoryEventVoteAsync_003Ed__145 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StoryEventVoteResp> _003C_003Et__builder;

			public StoryEventVoteReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkApple_003Ed__148 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountApple req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkAppleAsync_003Ed__147 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountApple req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkDevice_003Ed__150 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountDevice req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkDeviceAsync_003Ed__149 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountDevice req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkEmail_003Ed__152 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountEmail req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkEmailAsync_003Ed__151 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountEmail req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkFacebook_003Ed__154 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountFacebook req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkFacebookAsync_003Ed__153 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountFacebook req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkFacebookInstantGame_003Ed__156 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountFacebookInstantGame req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkFacebookInstantGameAsync_003Ed__155 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountFacebookInstantGame req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkGameCenter_003Ed__158 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountGameCenter req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkGameCenterAsync_003Ed__157 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountGameCenter req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkGoogle_003Ed__160 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public AccountGoogle req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkGoogleAsync_003Ed__159 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public AccountGoogle req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnlinkVoodooId_003Ed__162 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public VoodooId req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<VoodooAccount> success;

			private TaskAwaiter<VoodooAccount> _003C_003Eu__1;

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
		private struct _003CUnlinkVoodooIdAsync_003Ed__161 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<VoodooAccount> _003C_003Et__builder;

			public VoodooId req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateAccount_003Ed__164 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public UpdateAccountRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<Empty> success;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateAccountAsync_003Ed__163 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Empty> _003C_003Et__builder;

			public UpdateAccountRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateCheck_003Ed__166 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public UpdateCheckRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<UpdateCheckResponse> success;

			private TaskAwaiter<UpdateCheckResponse> _003C_003Eu__1;

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
		private struct _003CUpdateCheckAsync_003Ed__165 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UpdateCheckResponse> _003C_003Et__builder;

			public UpdateCheckRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdatePlayerProfile_003Ed__193 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public UpdatePlayerProfileReq req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<UpdatePlayerProfileResp> success;

			private TaskAwaiter<UpdatePlayerProfileResp> _003C_003Eu__1;

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
		private struct _003CUpdatePlayerProfileAsync_003Ed__192 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UpdatePlayerProfileResp> _003C_003Et__builder;

			public UpdatePlayerProfileReq req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CVersion_003Ed__168 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<StringValue> success;

			private TaskAwaiter<StringValue> _003C_003Eu__1;

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
		private struct _003CVersionAsync_003Ed__167 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StringValue> _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteLeaderboardRecord_003Ed__179 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public NakamaHttpClient _003C_003E4__this;

			public WriteLeaderboardRecordRequest req;

			public Action<ApiResponseException> apiFail;

			public Action<Exception> genericFail;

			public Action<LeaderboardRecord> success;

			private TaskAwaiter<LeaderboardRecord> _003C_003Eu__1;

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
		private struct _003CWriteLeaderboardRecordAsync_003Ed__178 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LeaderboardRecord> _003C_003Et__builder;

			public WriteLeaderboardRecordRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWriteStorageObjectsAsync_003Ed__169 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StorageObjectAcks> _003C_003Et__builder;

			public WriteStorageObjectsRequest req;

			public NakamaHttpClient _003C_003E4__this;

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

		public readonly IHttpAdapter HttpAdapter;

		public readonly Uri BaseUri;

		private bool _autoRefresh;

		private string _serverKey;

		private ILogger _logger;

		private string _version;

		private string _platform;

		public int Timeout { get; set; }

		public ISession Session { get; private set; }

		public ILogger Logger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NakamaHttpClient(string scheme, string host, int port, string serverKey, INakamaCallbacks callbacks, bool autoRefreshSession = true, int timeout = 15, string version = "0.0.0", string platform = "none")
		{
		}

		public string GetCookieString()
		{
			return null;
		}

		private string ParseForUrl(string s)
		{
			return null;
		}

		private string ParseForUrl(bool? b)
		{
			return null;
		}

		private string ParseForUrl(int? i)
		{
			return null;
		}

		public void AssignSession(ISession session)
		{
		}

		[AsyncStateMachine(typeof(_003CAddRewardItemsDebugAsync_003Ed__24))]
		public Task<AddRewardItemsDebugResp> AddRewardItemsDebugAsync(AddRewardItemsDebugReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddRewardItemsDebug_003Ed__25))]
		public void AddRewardItemsDebug(AddRewardItemsDebugReq req, Action<AddRewardItemsDebugResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAddUpdateCheckRuleAsync_003Ed__26))]
		public Task<BoolValue> AddUpdateCheckRuleAsync(UpdateCheckRuleRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddUpdateCheckRule_003Ed__27))]
		public void AddUpdateCheckRule(UpdateCheckRuleRequest req, Action<BoolValue> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAssociateVoodooIdAsync_003Ed__28))]
		public Task<VoodooAccount> AssociateVoodooIdAsync(VoodooId req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAssociateVoodooId_003Ed__29))]
		public void AssociateVoodooId(VoodooId req, Action<VoodooAccount> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateAppleAsync_003Ed__30))]
		public Task<Session> AuthenticateAppleAsync(AuthenticateAppleRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateApple_003Ed__31))]
		public void AuthenticateApple(AuthenticateAppleRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateDeviceAsync_003Ed__32))]
		public Task<Session> AuthenticateDeviceAsync(AuthenticateDeviceRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateDevice_003Ed__33))]
		public void AuthenticateDevice(AuthenticateDeviceRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateEmailAsync_003Ed__34))]
		public Task<Session> AuthenticateEmailAsync(AuthenticateEmailRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateEmail_003Ed__35))]
		public void AuthenticateEmail(AuthenticateEmailRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateEmailRequestCodeAsync_003Ed__36))]
		public Task<Empty> AuthenticateEmailRequestCodeAsync(AuthenticateEmailRequestCodeRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateEmailRequestCode_003Ed__37))]
		public void AuthenticateEmailRequestCode(AuthenticateEmailRequestCodeRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateEmailVerifyCodeAsync_003Ed__38))]
		public Task<Session> AuthenticateEmailVerifyCodeAsync(AuthenticateEmailVerifyCodeRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateEmailVerifyCode_003Ed__39))]
		public void AuthenticateEmailVerifyCode(AuthenticateEmailVerifyCodeRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateFacebookAsync_003Ed__40))]
		public Task<Session> AuthenticateFacebookAsync(AuthenticateFacebookRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateFacebook_003Ed__41))]
		public void AuthenticateFacebook(AuthenticateFacebookRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateFacebookInstantGameAsync_003Ed__42))]
		public Task<Session> AuthenticateFacebookInstantGameAsync(AuthenticateFacebookInstantGameRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateFacebookInstantGame_003Ed__43))]
		public void AuthenticateFacebookInstantGame(AuthenticateFacebookInstantGameRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateGameCenterAsync_003Ed__44))]
		public Task<Session> AuthenticateGameCenterAsync(AuthenticateGameCenterRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateGameCenter_003Ed__45))]
		public void AuthenticateGameCenter(AuthenticateGameCenterRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CAuthenticateGoogleAsync_003Ed__46))]
		public Task<Session> AuthenticateGoogleAsync(AuthenticateGoogleRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticateGoogle_003Ed__47))]
		public void AuthenticateGoogle(AuthenticateGoogleRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CClaimGiftsAsync_003Ed__48))]
		public Task<ClaimGiftsResp> ClaimGiftsAsync(ClaimGiftsReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClaimGifts_003Ed__49))]
		public void ClaimGifts(ClaimGiftsReq req, Action<ClaimGiftsResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CClearAllUpdateCheckRulesAsync_003Ed__50))]
		public Task<BoolValue> ClearAllUpdateCheckRulesAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClearAllUpdateCheckRules_003Ed__51))]
		public void ClearAllUpdateCheckRules(Action<BoolValue> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CCodeGenEchoAsync_003Ed__52))]
		public Task<CodegenEchoMessage> CodeGenEchoAsync(CodegenEchoMessage req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCodeGenEcho_003Ed__53))]
		public void CodeGenEcho(CodegenEchoMessage req, Action<CodegenEchoMessage> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CCodegenAsync_003Ed__54))]
		public Task<Empty> CodegenAsync(GenericRpcMessageContainer req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCodegen_003Ed__55))]
		public void Codegen(GenericRpcMessageContainer req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CCollectListAsync_003Ed__56))]
		public Task<CollectListResp> CollectListAsync(CollectListReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCollectList_003Ed__57))]
		public void CollectList(CollectListReq req, Action<CollectListResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteAccountAsync_003Ed__58))]
		public Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteAccount_003Ed__59))]
		public void DeleteAccount(DeleteAccountRequest req, Action<DeleteAccountResponse> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteFeatureRoundAsync_003Ed__60))]
		public Task<FeatureRoundsResp> DeleteFeatureRoundAsync(FeatureRoundDeleteReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteFeatureRound_003Ed__61))]
		public void DeleteFeatureRound(FeatureRoundDeleteReq req, Action<FeatureRoundsResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteFeatureRoundsAsync_003Ed__62))]
		public Task<Empty> DeleteFeatureRoundsAsync(FeatureId req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteFeatureRounds_003Ed__63))]
		public void DeleteFeatureRounds(FeatureId req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteRewardItemsDebugAsync_003Ed__64))]
		public Task<DeleteRewardItemsDebugResp> DeleteRewardItemsDebugAsync(DeleteRewardItemsDebugReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteRewardItemsDebug_003Ed__65))]
		public void DeleteRewardItemsDebug(DeleteRewardItemsDebugReq req, Action<DeleteRewardItemsDebugResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteStorageObjectsAsync_003Ed__66))]
		public Task<Empty> DeleteStorageObjectsAsync(DeleteStorageObjectsRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteStorageObjects_003Ed__67))]
		public void DeleteStorageObjects(DeleteStorageObjectsRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CEchoAsync_003Ed__68))]
		public Task<EchoResponse> EchoAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CEcho_003Ed__69))]
		public void Echo(Action<EchoResponse> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetAccountAsync_003Ed__70))]
		public Task<Account> GetAccountAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAccount_003Ed__71))]
		public void GetAccount(Action<Account> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetCompetitiveEventsMinVersionAsync_003Ed__72))]
		public Task<GetCompetitiveEventsMinVersionResp> GetCompetitiveEventsMinVersionAsync(GetCompetitiveEventsMinVersionReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetCompetitiveEventsMinVersion_003Ed__73))]
		public void GetCompetitiveEventsMinVersion(GetCompetitiveEventsMinVersionReq req, Action<GetCompetitiveEventsMinVersionResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetNotFinishedFeatureRoundsAsync_003Ed__74))]
		public Task<FeatureRoundsResp> GetNotFinishedFeatureRoundsAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetNotFinishedFeatureRounds_003Ed__75))]
		public void GetNotFinishedFeatureRounds(Action<FeatureRoundsResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPendingGiftsAsync_003Ed__76))]
		public Task<GetPendingGiftsResp> GetPendingGiftsAsync(GetPendingGiftsReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPendingGifts_003Ed__77))]
		public void GetPendingGifts(GetPendingGiftsReq req, Action<GetPendingGiftsResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetScheduledFeatureRoundsAsync_003Ed__78))]
		public Task<FeatureRoundsResp> GetScheduledFeatureRoundsAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetScheduledFeatureRounds_003Ed__79))]
		public void GetScheduledFeatureRounds(Action<FeatureRoundsResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetUserClientAttributesAsync_003Ed__80))]
		public Task<GetUserClientAttributesResp> GetUserClientAttributesAsync(GetUserClientAttributesReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetUserClientAttributes_003Ed__81))]
		public void GetUserClientAttributes(GetUserClientAttributesReq req, Action<GetUserClientAttributesResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetVoodooTuneConfigAsync_003Ed__82))]
		public Task<GetVoodooTuneConfigResp> GetVoodooTuneConfigAsync(GetVoodooTuneConfigReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetVoodooTuneConfig_003Ed__83))]
		public void GetVoodooTuneConfig(GetVoodooTuneConfigReq req, Action<GetVoodooTuneConfigResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetVoodooTuneConfigWithFallbackAsync_003Ed__84))]
		public Task<GetVoodooTuneConfigResp> GetVoodooTuneConfigWithFallbackAsync(GetVoodooTuneConfigReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetVoodooTuneConfigWithFallback_003Ed__85))]
		public void GetVoodooTuneConfigWithFallback(GetVoodooTuneConfigReq req, Action<GetVoodooTuneConfigResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CImportFacebookFriendsAsync_003Ed__86))]
		public Task<Empty> ImportFacebookFriendsAsync(ImportFacebookFriendsRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CImportFacebookFriends_003Ed__87))]
		public void ImportFacebookFriends(ImportFacebookFriendsRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CInvitationsAcceptAsync_003Ed__88))]
		public Task<InvitationsAcceptResp> InvitationsAcceptAsync(InvitationsAcceptReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInvitationsAccept_003Ed__89))]
		public void InvitationsAccept(InvitationsAcceptReq req, Action<InvitationsAcceptResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CInvitationsAcceptDebugAsync_003Ed__90))]
		public Task<InvitationsAcceptDebugResp> InvitationsAcceptDebugAsync(InvitationsAcceptDebugReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInvitationsAcceptDebug_003Ed__91))]
		public void InvitationsAcceptDebug(InvitationsAcceptDebugReq req, Action<InvitationsAcceptDebugResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CInvitationsSyncAsync_003Ed__92))]
		public Task<InvitationsSyncResp> InvitationsSyncAsync(InvitationsSyncReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInvitationsSync_003Ed__93))]
		public void InvitationsSync(InvitationsSyncReq req, Action<InvitationsSyncResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkAppleAsync_003Ed__94))]
		public Task<Empty> LinkAppleAsync(AccountApple req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkApple_003Ed__95))]
		public void LinkApple(AccountApple req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkDeviceAsync_003Ed__96))]
		public Task<Empty> LinkDeviceAsync(AccountDevice req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkDevice_003Ed__97))]
		public void LinkDevice(AccountDevice req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkEmailAsync_003Ed__98))]
		public Task<Empty> LinkEmailAsync(AccountEmail req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkEmail_003Ed__99))]
		public void LinkEmail(AccountEmail req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkEmailRequestCodeAsync_003Ed__100))]
		public Task<Empty> LinkEmailRequestCodeAsync(LinkEmailRequestCodeRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkEmailRequestCode_003Ed__101))]
		public void LinkEmailRequestCode(LinkEmailRequestCodeRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkEmailVerifyCodeAsync_003Ed__102))]
		public Task<Empty> LinkEmailVerifyCodeAsync(LinkEmailVerifyCodeRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkEmailVerifyCode_003Ed__103))]
		public void LinkEmailVerifyCode(LinkEmailVerifyCodeRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkFacebookAsync_003Ed__104))]
		public Task<Empty> LinkFacebookAsync(LinkFacebookRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkFacebook_003Ed__105))]
		public void LinkFacebook(LinkFacebookRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkFacebookInstantGameAsync_003Ed__106))]
		public Task<Empty> LinkFacebookInstantGameAsync(AccountFacebookInstantGame req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkFacebookInstantGame_003Ed__107))]
		public void LinkFacebookInstantGame(AccountFacebookInstantGame req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkGameCenterAsync_003Ed__108))]
		public Task<Empty> LinkGameCenterAsync(AccountGameCenter req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkGameCenter_003Ed__109))]
		public void LinkGameCenter(AccountGameCenter req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkGoogleAsync_003Ed__110))]
		public Task<Empty> LinkGoogleAsync(AccountGoogle req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLinkGoogle_003Ed__111))]
		public void LinkGoogle(AccountGoogle req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CListChannelMessagesAsync_003Ed__112))]
		public Task<ChannelMessageList> ListChannelMessagesAsync(ListChannelMessagesRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListChannelMessages_003Ed__113))]
		public void ListChannelMessages(ListChannelMessagesRequest req, Action<ChannelMessageList> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CMergeAccountAsync_003Ed__114))]
		public Task<MergeAccountResponse> MergeAccountAsync(MergeAccountRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003COneSignalSendStringNotificationDebugAsync_003Ed__115))]
		public Task<OneSignalSendStringNotificationDebugResponse> OneSignalSendStringNotificationDebugAsync(OneSignalSendStringNotificationDebugRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003COneSignalSendStringNotificationDebug_003Ed__116))]
		public void OneSignalSendStringNotificationDebug(OneSignalSendStringNotificationDebugRequest req, Action<OneSignalSendStringNotificationDebugResponse> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003COneSignalSendTemplateNotificationDebugAsync_003Ed__117))]
		public Task<OneSignalSendTemplateNotificationDebugResponse> OneSignalSendTemplateNotificationDebugAsync(OneSignalSendTemplateNotificationDebugRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003COneSignalSendTemplateNotificationDebug_003Ed__118))]
		public void OneSignalSendTemplateNotificationDebug(OneSignalSendTemplateNotificationDebugRequest req, Action<OneSignalSendTemplateNotificationDebugResponse> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CReadStorageObjectsAsync_003Ed__119))]
		public Task<StorageObjects> ReadStorageObjectsAsync(ReadStorageObjectsRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadStorageObjects_003Ed__120))]
		public void ReadStorageObjects(ReadStorageObjectsRequest req, Action<StorageObjects> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CReadinessAsync_003Ed__121))]
		public Task<Empty> ReadinessAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadiness_003Ed__122))]
		public void Readiness(Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CRemoveUpdateCheckRuleAsync_003Ed__123))]
		public Task<BoolValue> RemoveUpdateCheckRuleAsync(UpdateCheckRuleRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRemoveUpdateCheckRule_003Ed__124))]
		public void RemoveUpdateCheckRule(UpdateCheckRuleRequest req, Action<BoolValue> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CResetCompetitiveEventsMinVersionAsync_003Ed__125))]
		public Task<ResetCompetitiveEventsMinVersionResp> ResetCompetitiveEventsMinVersionAsync(ResetCompetitiveEventsMinVersionReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CResetCompetitiveEventsMinVersion_003Ed__126))]
		public void ResetCompetitiveEventsMinVersion(ResetCompetitiveEventsMinVersionReq req, Action<ResetCompetitiveEventsMinVersionResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CScheduleFeatureRoundAsync_003Ed__127))]
		public Task<FeatureRoundsResp> ScheduleFeatureRoundAsync(FeatureRoundOptions req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CScheduleFeatureRound_003Ed__128))]
		public void ScheduleFeatureRound(FeatureRoundOptions req, Action<FeatureRoundsResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CSendGiftsDebugAsync_003Ed__129))]
		public Task<SendGiftsDebugResp> SendGiftsDebugAsync(SendGiftsDebugReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendGiftsDebug_003Ed__130))]
		public void SendGiftsDebug(SendGiftsDebugReq req, Action<SendGiftsDebugResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CServerTimeAsync_003Ed__131))]
		public Task<ServerTime> ServerTimeAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CServerTime_003Ed__132))]
		public void ServerTime(Action<ServerTime> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CSessionRefreshAsync_003Ed__133))]
		public Task<Session> SessionRefreshAsync(SessionRefreshRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSessionRefresh_003Ed__134))]
		public void SessionRefresh(SessionRefreshRequest req, Action<Session> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CSetVoodooTuneConfigDebugAsync_003Ed__135))]
		public Task<SetVoodooTuneConfigResp> SetVoodooTuneConfigDebugAsync(SetVoodooTuneConfigReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSetVoodooTuneConfigDebug_003Ed__136))]
		public void SetVoodooTuneConfigDebug(SetVoodooTuneConfigReq req, Action<SetVoodooTuneConfigResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CSleepAsync_003Ed__137))]
		public Task<Empty> SleepAsync(SleepReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSleep_003Ed__138))]
		public void Sleep(SleepReq req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CStopHammertimeAsync_003Ed__139))]
		public Task<Empty> StopHammertimeAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStopHammertime_003Ed__140))]
		public void StopHammertime(Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CStoryEventListAsync_003Ed__141))]
		public Task<StoryEventListResp> StoryEventListAsync(StoryEventListReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStoryEventList_003Ed__142))]
		public void StoryEventList(StoryEventListReq req, Action<StoryEventListResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CStoryEventSyncAsync_003Ed__143))]
		public Task<StoryEventSyncResp> StoryEventSyncAsync(StoryEventSyncReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStoryEventSync_003Ed__144))]
		public void StoryEventSync(StoryEventSyncReq req, Action<StoryEventSyncResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CStoryEventVoteAsync_003Ed__145))]
		public Task<StoryEventVoteResp> StoryEventVoteAsync(StoryEventVoteReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStoryEventVote_003Ed__146))]
		public void StoryEventVote(StoryEventVoteReq req, Action<StoryEventVoteResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkAppleAsync_003Ed__147))]
		public Task<Empty> UnlinkAppleAsync(AccountApple req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkApple_003Ed__148))]
		public void UnlinkApple(AccountApple req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkDeviceAsync_003Ed__149))]
		public Task<Empty> UnlinkDeviceAsync(AccountDevice req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkDevice_003Ed__150))]
		public void UnlinkDevice(AccountDevice req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkEmailAsync_003Ed__151))]
		public Task<Empty> UnlinkEmailAsync(AccountEmail req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkEmail_003Ed__152))]
		public void UnlinkEmail(AccountEmail req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkFacebookAsync_003Ed__153))]
		public Task<Empty> UnlinkFacebookAsync(AccountFacebook req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkFacebook_003Ed__154))]
		public void UnlinkFacebook(AccountFacebook req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkFacebookInstantGameAsync_003Ed__155))]
		public Task<Empty> UnlinkFacebookInstantGameAsync(AccountFacebookInstantGame req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkFacebookInstantGame_003Ed__156))]
		public void UnlinkFacebookInstantGame(AccountFacebookInstantGame req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkGameCenterAsync_003Ed__157))]
		public Task<Empty> UnlinkGameCenterAsync(AccountGameCenter req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkGameCenter_003Ed__158))]
		public void UnlinkGameCenter(AccountGameCenter req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkGoogleAsync_003Ed__159))]
		public Task<Empty> UnlinkGoogleAsync(AccountGoogle req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkGoogle_003Ed__160))]
		public void UnlinkGoogle(AccountGoogle req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUnlinkVoodooIdAsync_003Ed__161))]
		public Task<VoodooAccount> UnlinkVoodooIdAsync(VoodooId req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnlinkVoodooId_003Ed__162))]
		public void UnlinkVoodooId(VoodooId req, Action<VoodooAccount> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateAccountAsync_003Ed__163))]
		public Task<Empty> UpdateAccountAsync(UpdateAccountRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateAccount_003Ed__164))]
		public void UpdateAccount(UpdateAccountRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateCheckAsync_003Ed__165))]
		public Task<UpdateCheckResponse> UpdateCheckAsync(UpdateCheckRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateCheck_003Ed__166))]
		public void UpdateCheck(UpdateCheckRequest req, Action<UpdateCheckResponse> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CVersionAsync_003Ed__167))]
		public Task<StringValue> VersionAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CVersion_003Ed__168))]
		public void Version(Action<StringValue> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CWriteStorageObjectsAsync_003Ed__169))]
		public Task<StorageObjectAcks> WriteStorageObjectsAsync(WriteStorageObjectsRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardPlayerDataRecordsAsync_003Ed__170))]
		public Task<LeaderboardPlayerDataRecordList> ListLeaderboardPlayerDataRecordsAsync(ListLeaderboardRecordsRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardPlayerDataRecords_003Ed__171))]
		public void ListLeaderboardPlayerDataRecords(ListLeaderboardRecordsRequest req, Action<LeaderboardPlayerDataRecordList> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardPlayerDataRecordsAroundOwnerAsync_003Ed__172))]
		public Task<LeaderboardPlayerDataRecordList> ListLeaderboardPlayerDataRecordsAroundOwnerAsync(ListLeaderboardRecordsAroundOwnerRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardPlayerDataRecordsAroundOwner_003Ed__173))]
		public void ListLeaderboardPlayerDataRecordsAroundOwner(ListLeaderboardRecordsAroundOwnerRequest req, Action<LeaderboardPlayerDataRecordList> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardRecordsAsync_003Ed__174))]
		public Task<LeaderboardRecordList> ListLeaderboardRecordsAsync(ListLeaderboardRecordsRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardRecords_003Ed__175))]
		public void ListLeaderboardRecords(ListLeaderboardRecordsRequest req, Action<LeaderboardRecordList> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardRecordsAroundOwnerAsync_003Ed__176))]
		public Task<LeaderboardRecordList> ListLeaderboardRecordsAroundOwnerAsync(ListLeaderboardRecordsAroundOwnerRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListLeaderboardRecordsAroundOwner_003Ed__177))]
		public void ListLeaderboardRecordsAroundOwner(ListLeaderboardRecordsAroundOwnerRequest req, Action<LeaderboardRecordList> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CWriteLeaderboardRecordAsync_003Ed__178))]
		public Task<LeaderboardRecord> WriteLeaderboardRecordAsync(WriteLeaderboardRecordRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWriteLeaderboardRecord_003Ed__179))]
		public void WriteLeaderboardRecord(WriteLeaderboardRecordRequest req, Action<LeaderboardRecord> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDebugCreateLeaderboardAsync_003Ed__180))]
		public Task<Leaderboard> DebugCreateLeaderboardAsync(CreateLeaderboard req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDebugCreateLeaderboard_003Ed__181))]
		public void DebugCreateLeaderboard(CreateLeaderboard req, Action<Leaderboard> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CDeleteLeaderboardRecordAsync_003Ed__182))]
		public Task<Empty> DeleteLeaderboardRecordAsync(DeleteLeaderboardRecordRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDeleteLeaderboardRecord_003Ed__183))]
		public void DeleteLeaderboardRecord(DeleteLeaderboardRecordRequest req, Action<Empty> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CLeaderboardDeleteOwnersOlderThanAsync_003Ed__184))]
		public Task<LeaderboardCleanupResponse> LeaderboardDeleteOwnersOlderThanAsync(LeaderboardCleanupRequest req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLeaderboardDeleteOwnersOlderThan_003Ed__185))]
		public void LeaderboardDeleteOwnersOlderThan(LeaderboardCleanupRequest req, Action<LeaderboardCleanupResponse> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPlayerProfileAsync_003Ed__186))]
		public Task<GetPlayerProfileResp> GetPlayerProfileAsync(GetPlayerProfileReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPlayerProfile_003Ed__187))]
		public void GetPlayerProfile(GetPlayerProfileReq req, Action<GetPlayerProfileResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPlayerProfilesAsync_003Ed__188))]
		public Task<GetPlayerProfilesResp> GetPlayerProfilesAsync(GetPlayerProfilesReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPlayerProfiles_003Ed__189))]
		public void GetPlayerProfiles(GetPlayerProfilesReq req, Action<GetPlayerProfilesResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPlayerProfilesWithFallbackAsync_003Ed__190))]
		public Task<GetPlayerProfilesResp> GetPlayerProfilesWithFallbackAsync(GetPlayerProfilesReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPlayerProfilesWithFallback_003Ed__191))]
		public void GetPlayerProfilesWithFallback(GetPlayerProfilesReq req, Action<GetPlayerProfilesResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdatePlayerProfileAsync_003Ed__192))]
		public Task<UpdatePlayerProfileResp> UpdatePlayerProfileAsync(UpdatePlayerProfileReq req)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdatePlayerProfile_003Ed__193))]
		public void UpdatePlayerProfile(UpdatePlayerProfileReq req, Action<UpdatePlayerProfileResp> success, Action<ApiResponseException> apiFail, Action<Exception> genericFail)
		{
		}
	}
}
