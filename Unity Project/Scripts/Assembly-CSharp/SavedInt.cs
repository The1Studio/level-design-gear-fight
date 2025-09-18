using System;

public class SavedInt
{
	private string _saveString;

	private int _currentValue;

	private int _defaultValue;

	private bool _saveOnChange;

	private Action _onChanged;

	public int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public SavedInt(string saveString, int defaultValue, bool saveOnChange, Action onChange)
	{
	}

	public void Save()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static implicit operator int(SavedInt v)
	{
		return 0;
	}
}
