using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class CustomLabelAndValueAttribute : PropertyAttribute
{
	public readonly string Name;

	public readonly bool Separator;

	public CustomLabelAndValueAttribute(string name, bool separator = false)
	{
	}
}
