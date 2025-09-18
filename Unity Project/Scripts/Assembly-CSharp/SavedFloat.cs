using System;

public class SavedFloat
{
	private string _saveString;

	private float _currentValue;

	private float _defaultValue;

	private bool _saveOnChange;

	private Action _onChanged;

	public float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public SavedFloat(string saveString, float defaultValue, bool saveOnChange, Action onChange)
	{
	}

	public void Save()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static implicit operator float(SavedFloat v)
	{
		return 0f;
	}
}
