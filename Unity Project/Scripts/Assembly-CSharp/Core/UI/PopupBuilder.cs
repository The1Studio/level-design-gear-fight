using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Core.UI
{
	public class PopupBuilder<T> where T : Popup
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public bool value;

			internal bool _003CWaitUntil_003Eb__1()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitUntil_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<T> action;

			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitUntil_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitUntilClosed_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopupBuilder<T> _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitUntilClosed_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitUntilOpened_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PopupBuilder<T> _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitUntilOpened_003Ed__11(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private PopupData<T> _data;

		internal PopupBuilder(string id, out PopupData<T> popupData)
		{
			popupData = null;
		}

		public PopupBuilder<T> OnClose(Action<T> onClose)
		{
			return null;
		}

		public PopupBuilder<T> OnOpen(Action<T> onOpen)
		{
			return null;
		}

		public PopupBuilder<T> OnDestroy(Action<T> onDestroy)
		{
			return null;
		}

		public PopupBuilder<T> SetBackdrop(BackdropUsage backdropUsage = BackdropUsage.BlockRaycast)
		{
			return null;
		}

		public PopupBuilder<T> SetPriority(int priority = 0)
		{
			return null;
		}

		public PopupBuilder<T> SetReusable()
		{
			return null;
		}

		public void Cancel()
		{
		}

		public T Build()
		{
			return null;
		}

		[IteratorStateMachine(typeof(PopupBuilder<>._003CWaitUntil_003Ed__10))]
		private IEnumerator WaitUntil(Action<T> action)
		{
			return null;
		}

		[IteratorStateMachine(typeof(PopupBuilder<>._003CWaitUntilOpened_003Ed__11))]
		public IEnumerator WaitUntilOpened()
		{
			return null;
		}

		[IteratorStateMachine(typeof(PopupBuilder<>._003CWaitUntilClosed_003Ed__12))]
		public IEnumerator WaitUntilClosed()
		{
			return null;
		}
	}
}
