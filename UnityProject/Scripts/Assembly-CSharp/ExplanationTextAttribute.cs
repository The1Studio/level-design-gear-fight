using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class ExplanationTextAttribute : PropertyAttribute
{
	public readonly string Text;

	public ExplanationTextAttribute(string text)
	{
	}
}
