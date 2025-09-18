using System;
using UnityEngine;

[Serializable]
public class SerializableVector3
{
	public float X;

	public float Y;

	public float Z;

	public Vector3 Get()
	{
		return default(Vector3);
	}

	public SerializableVector3(Vector3 vec)
	{
	}
}
