namespace Nakama
{
	public interface IStream
	{
		string Descriptor { get; }

		string Label { get; }

		int Mode { get; }

		string Subject { get; }
	}
}
