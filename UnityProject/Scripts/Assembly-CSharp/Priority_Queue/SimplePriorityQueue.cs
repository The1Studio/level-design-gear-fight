using System;
using System.Collections;
using System.Collections.Generic;

namespace Priority_Queue
{
	public class SimplePriorityQueue<TItem, TPriority> : IPriorityQueue<TItem, TPriority>, IEnumerable<TItem>, IEnumerable where TPriority : IComparable<TPriority>
	{
		private class SimpleNode : GenericPriorityQueueNode<TPriority>
		{
			public TItem Data { get; private set; }

			public SimpleNode(TItem data)
			{
			}
		}

		private const int INITIAL_QUEUE_SIZE = 10;

		private readonly GenericPriorityQueue<SimpleNode, TPriority> _queue;

		private readonly Dictionary<TItem, IList<SimpleNode>> _itemToNodesCache;

		private readonly IList<SimpleNode> _nullNodesCache;

		public int Count => 0;

		public TItem First => default(TItem);

		public SimplePriorityQueue()
		{
		}

		public SimplePriorityQueue(IComparer<TPriority> priorityComparer)
		{
		}

		public SimplePriorityQueue(Comparison<TPriority> priorityComparer)
		{
		}

		public SimplePriorityQueue(IEqualityComparer<TItem> itemEquality)
		{
		}

		public SimplePriorityQueue(IComparer<TPriority> priorityComparer, IEqualityComparer<TItem> itemEquality)
		{
		}

		public SimplePriorityQueue(Comparison<TPriority> priorityComparer, IEqualityComparer<TItem> itemEquality)
		{
		}

		private SimpleNode GetExistingNode(TItem item)
		{
			return null;
		}

		private void AddToNodeCache(SimpleNode node)
		{
		}

		private void RemoveFromNodeCache(SimpleNode node)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TItem item)
		{
			return false;
		}

		public TItem Dequeue()
		{
			return default(TItem);
		}

		private SimpleNode EnqueueNoLockOrCache(TItem item, TPriority priority)
		{
			return null;
		}

		public void Enqueue(TItem item, TPriority priority)
		{
		}

		public bool EnqueueWithoutDuplicates(TItem item, TPriority priority)
		{
			return false;
		}

		public void Remove(TItem item)
		{
		}

		public void UpdatePriority(TItem item, TPriority priority)
		{
		}

		public TPriority GetPriority(TItem item)
		{
			return default(TPriority);
		}

		public bool TryFirst(out TItem first)
		{
			first = default(TItem);
			return false;
		}

		public bool TryDequeue(out TItem first)
		{
			first = default(TItem);
			return false;
		}

		public bool TryRemove(TItem item)
		{
			return false;
		}

		public bool TryUpdatePriority(TItem item, TPriority priority)
		{
			return false;
		}

		public bool TryGetPriority(TItem item, out TPriority priority)
		{
			priority = default(TPriority);
			return false;
		}

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
	public class SimplePriorityQueue<TItem> : SimplePriorityQueue<TItem, float>
	{
		public SimplePriorityQueue()
		{
		}

		public SimplePriorityQueue(IComparer<float> comparer)
		{
		}

		public SimplePriorityQueue(Comparison<float> comparer)
		{
		}
	}
}
