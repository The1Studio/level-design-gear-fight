using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Priority_Queue
{
	public sealed class GenericPriorityQueue<TItem, TPriority> : IFixedSizePriorityQueue<TItem, TPriority>, IPriorityQueue<TItem, TPriority>, IEnumerable<TItem>, IEnumerable where TItem : GenericPriorityQueueNode<TPriority> where TPriority : IComparable<TPriority>
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__25 : IEnumerator<TItem>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TItem _003C_003E2__current;

			public GenericPriorityQueue<TItem, TPriority> _003C_003E4__this;

			private int _003Ci_003E5__2;

			TItem IEnumerator<TItem>.Current
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
			public _003CGetEnumerator_003Ed__25(int _003C_003E1__state)
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

		private int _numNodes;

		private TItem[] _nodes;

		private long _numNodesEverEnqueued;

		private readonly Comparison<TPriority> _comparer;

		public int Count => 0;

		public int MaxSize => 0;

		public TItem First => null;

		public GenericPriorityQueue(int maxNodes)
		{
		}

		public GenericPriorityQueue(int maxNodes, IComparer<TPriority> comparer)
		{
		}

		public GenericPriorityQueue(int maxNodes, Comparison<TPriority> comparer)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TItem node)
		{
			return false;
		}

		public void Enqueue(TItem node, TPriority priority)
		{
		}

		private void CascadeUp(TItem node)
		{
		}

		private void CascadeDown(TItem node)
		{
		}

		private bool HasHigherPriority(TItem higher, TItem lower)
		{
			return false;
		}

		public TItem Dequeue()
		{
			return null;
		}

		public void Resize(int maxNodes)
		{
		}

		public void UpdatePriority(TItem node, TPriority priority)
		{
		}

		private void OnNodeUpdated(TItem node)
		{
		}

		public void Remove(TItem node)
		{
		}

		public void ResetNode(TItem node)
		{
		}

		[IteratorStateMachine(typeof(GenericPriorityQueue<, >._003CGetEnumerator_003Ed__25))]
		public IEnumerator<TItem> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool IsValidQueue()
		{
			return false;
		}
	}
}
