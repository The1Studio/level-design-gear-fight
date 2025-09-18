namespace Core.Event
{
	public interface INotificationEventData
	{
		string[] GetAttributes();

		T GetValue<T>(string attribute);

		bool IsValid();
	}
}
