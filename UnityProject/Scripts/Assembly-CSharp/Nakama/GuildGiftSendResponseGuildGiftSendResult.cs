namespace Nakama
{
	public enum GuildGiftSendResponseGuildGiftSendResult
	{
		SUCCESS = 0,
		ALREADY_SENT = 1,
		REQUEST_EXPIRED = 2,
		GIFTS_LIMIT_REACHED = 3,
		CANT_SEND_TO_ONESELF = 4,
		NOT_IN_GUILD = 5,
		FAILURE = 6
	}
}
