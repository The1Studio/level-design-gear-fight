using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class SubHeaderAttribute : PropertyAttribute
{
	public readonly string header;

	public SubHeaderAttribute(string header)
	{
	}
}
