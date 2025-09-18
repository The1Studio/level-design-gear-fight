using System;

public class SavedString
{
	private string _saveString;

	private string _currentValue;

	private string _defaultValue;

	private bool _saveOnChange;

	private Action _onChanged;

	private bool Initialised;

	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SavedString(string saveString, string defaultValue, bool saveOnChange, Action onChange)
	{
	}

	public void Save()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
