using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class WarningMessageAttribute : PropertyAttribute
{
	public readonly string message;

	public WarningMessageAttribute(string message)
	{
	}
}
