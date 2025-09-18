using System.Collections.Generic;
using UnityEngine;

public class GridGraph
{
	public int Width;

	public int Height;

	public Node[,] Grid;

	public List<Vector2Int> Walls;

	public GridGraph(int w, int h)
	{
	}

	public bool InBounds(Vector2Int v)
	{
		return false;
	}

	public bool Passable(Vector2Int id)
	{
		return false;
	}

	public List<Node> Neighbours(Node n)
	{
		return null;
	}
}
