using System;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class MediumSpacerAttribute : SpacerAttribute
{
	public const float SIZE = 20f;
}
