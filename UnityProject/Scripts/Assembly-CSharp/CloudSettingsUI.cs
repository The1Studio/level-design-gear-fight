using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CloudSettingsUI : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003COnLoginButtonClicked_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int loginType;

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

	[SerializeField]
	private TextMeshProUGUI _idText;

	[SerializeField]
	private Animator _copiedText;

	[SerializeField]
	private GameObject _loginRoot;

	[SerializeField]
	private GameObject _loggedInRoot;

	[SerializeField]
	[NonReorderable]
	private List<GameObject> _loginButtons;

	[SerializeField]
	private HorizontalLayoutGroup _bottomButtonLayoutGroup;

	public void Init()
	{
	}

	[AsyncStateMachine(typeof(_003COnLoginButtonClicked_003Ed__7))]
	public void OnLoginButtonClicked(int loginType)
	{
	}

	public void LogOut()
	{
	}

	public void DeleteAccount()
	{
	}

	private void OnDeleteError(HttpStatusCode code, string message)
	{
	}

	private void OnGenericError(Exception exception)
	{
	}

	public void CopyVoodooID()
	{
	}
}
