using System;

public class SavedBool
{
	private string _saveString;

	private bool _currentValue;

	private bool _defaultValue;

	private bool _saveOnChange;

	private Action _onChanged;

	private bool Initialised;

	public bool Value
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public SavedBool(string saveString, bool defaultValue, bool saveOnChange, Action onChange)
	{
	}

	public void Save()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static implicit operator bool(SavedBool v)
	{
		return false;
	}
}
