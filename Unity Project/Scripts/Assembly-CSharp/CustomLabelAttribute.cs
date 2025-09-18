using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class CustomLabelAttribute : PropertyAttribute
{
	public readonly string Name;

	public CustomLabelAttribute(string name)
	{
	}
}
