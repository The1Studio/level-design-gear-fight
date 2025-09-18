using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class LargeHeaderAttribute : PropertyAttribute
{
	public readonly string subHeader;

	public readonly string header;

	public LargeHeaderAttribute(string subHeader, string header)
	{
	}
}
