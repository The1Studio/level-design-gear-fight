using System;

public class SavedDateTime
{
	protected string _saveString;

	protected DateTime _currentValue;

	private bool IsInitialised;

	protected DateTime _defaultValue;

	protected bool _saveOnChange;

	private Action _onChanged;

	public DateTime Value
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public SavedDateTime(string saveString, DateTime defaultValue, bool saveOnChange, Action onChange)
	{
	}

	public virtual void Save()
	{
	}

	public DateTime Get()
	{
		return default(DateTime);
	}
}
