using System;
using UnityEngine;

public class Node : IComparable<Node>
{
	public Vector2Int Position;

	public float Priority;

	public Node(int x, int y)
	{
	}

	public int CompareTo(Node other)
	{
		return 0;
	}
}
