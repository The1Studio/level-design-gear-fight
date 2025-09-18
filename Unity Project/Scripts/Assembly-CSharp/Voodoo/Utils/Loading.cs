using System;
using System.Runtime.CompilerServices;

namespace Voodoo.Utils
{
	public class Loading : IDisposable
	{
		private sealed class Unsubscriber : IDisposable
		{
			private bool _disposed;

			private Action _unsubscribe;

			public Unsubscriber(Action unsubscribe)
			{
			}

			public void Dispose()
			{
			}
		}

		public bool _disposed;

		private int _state;

		private float _progress;

		private int _result;

		public int State
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Progress
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Result
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static event Action<int> _stateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<float> _progressChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<int> _completed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public IDisposable Subscribe(Action<int> stateChanged, Action<float> progressChanged = null, Action<int> completed = null)
		{
			return null;
		}

		public void Unsubscribe(Action<int> stateChanged, Action<float> progressChanged = null, Action<int> completed = null)
		{
		}

		public void Dispose()
		{
		}
	}
}
