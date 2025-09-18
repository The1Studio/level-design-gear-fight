namespace Voodoo.Sauce.Internal.Analytics
{
	public enum DebugAnalyticsStateEnum
	{
		ForwardedTo3rdParty = 1,
		ErrorSending = 2,
		Sent = 3,
		SentButErrorFromServer = 4,
		Error = 5
	}
}
