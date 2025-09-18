using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Voodoo.Utils
{
	public class Explorer<T>
	{
		private bool _disposed;

		public List<int> Selection { get; protected set; }

		public List<T> Items { get; protected set; }

		public T this[int key]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public event Action collectionChanged
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

		public event Action<T> itemAdded
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

		public event Action<int> itemRemoved
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

		public event Action<int[]> contextClicked
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

		public event Action<int[]> selectionChanged
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

		public void Select(int[] indexes)
		{
		}

		public void ContextClick(int[] selection)
		{
		}

		public void Fill(List<T> items)
		{
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}
	}
}
