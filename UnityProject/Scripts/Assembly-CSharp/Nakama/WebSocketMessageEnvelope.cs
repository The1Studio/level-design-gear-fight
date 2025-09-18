using System.Runtime.Serialization;

namespace Nakama
{
	public class WebSocketMessageEnvelope
	{
		[DataMember(Name = "cid")]
		[Preserve]
		public string Cid { get; set; }

		[DataMember(Name = "channel")]
		[Preserve]
		public Channel Channel { get; set; }

		[Preserve]
		[DataMember(Name = "channel_join")]
		public ChannelJoinMessage ChannelJoin { get; set; }

		[Preserve]
		[DataMember(Name = "channel_leave")]
		public ChannelLeaveMessage ChannelLeave { get; set; }

		[DataMember(Name = "channel_message")]
		[Preserve]
		public ApiChannelMessage ChannelMessage { get; set; }

		[DataMember(Name = "channel_message_ack")]
		[Preserve]
		public ChannelMessageAck ChannelMessageAck { get; set; }

		[DataMember(Name = "channel_message_remove")]
		[Preserve]
		public ChannelRemoveMessage ChannelMessageRemove { get; set; }

		[DataMember(Name = "channel_message_send")]
		[Preserve]
		public ChannelSendMessage ChannelMessageSend { get; set; }

		[DataMember(Name = "channel_message_update")]
		[Preserve]
		public ChannelUpdateMessage ChannelMessageUpdate { get; set; }

		[DataMember(Name = "channel_presence_event")]
		[Preserve]
		public ChannelPresenceEvent ChannelPresenceEvent { get; set; }

		[DataMember(Name = "error")]
		[Preserve]
		public WebSocketErrorMessage Error { get; set; }

		[Preserve]
		[DataMember(Name = "matchmaker_add")]
		public MatchmakerAddMessage MatchmakerAdd { get; set; }

		[Preserve]
		[DataMember(Name = "matchmaker_matched")]
		public MatchmakerMatched MatchmakerMatched { get; set; }

		[Preserve]
		[DataMember(Name = "matchmaker_remove")]
		public MatchmakerRemoveMessage MatchmakerRemove { get; set; }

		[DataMember(Name = "matchmaker_ticket")]
		[Preserve]
		public MatchmakerTicket MatchmakerTicket { get; set; }

		[Preserve]
		[DataMember(Name = "match")]
		public Match Match { get; set; }

		[DataMember(Name = "match_create")]
		[Preserve]
		public MatchCreateMessage MatchCreate { get; set; }

		[DataMember(Name = "match_join")]
		[Preserve]
		public MatchJoinMessage MatchJoin { get; set; }

		[DataMember(Name = "match_leave")]
		[Preserve]
		public MatchLeaveMessage MatchLeave { get; set; }

		[DataMember(Name = "match_presence_event")]
		[Preserve]
		public MatchPresenceEvent MatchPresenceEvent { get; set; }

		[DataMember(Name = "match_data")]
		[Preserve]
		public MatchState MatchState { get; set; }

		[DataMember(Name = "match_data_send")]
		[Preserve]
		public MatchSendMessage MatchStateSend { get; set; }

		[DataMember(Name = "notifications")]
		[Preserve]
		public ApiNotificationList NotificationList { get; set; }

		[Preserve]
		[DataMember(Name = "status")]
		public Status Status { get; set; }

		[Preserve]
		[DataMember(Name = "status_follow")]
		public StatusFollowMessage StatusFollow { get; set; }

		[Preserve]
		[DataMember(Name = "status_presence_event")]
		public StatusPresenceEvent StatusPresenceEvent { get; set; }

		[DataMember(Name = "status_unfollow")]
		[Preserve]
		public StatusUnfollowMessage StatusUnfollow { get; set; }

		[DataMember(Name = "status_update")]
		[Preserve]
		public StatusUpdateMessage StatusUpdate { get; set; }

		[DataMember(Name = "stream_presence_event")]
		[Preserve]
		public StreamPresenceEvent StreamPresenceEvent { get; set; }

		[DataMember(Name = "stream_data")]
		[Preserve]
		public StreamState StreamState { get; set; }

		[DataMember(Name = "party")]
		[Preserve]
		public Party Party { get; set; }

		[DataMember(Name = "party_create")]
		[Preserve]
		public PartyCreate PartyCreate { get; set; }

		[DataMember(Name = "party_join")]
		[Preserve]
		public PartyJoin PartyJoin { get; set; }

		[Preserve]
		[DataMember(Name = "party_leave")]
		public PartyLeave PartyLeave { get; set; }

		[DataMember(Name = "party_promote")]
		[Preserve]
		public PartyPromote PartyPromote { get; set; }

		[Preserve]
		[DataMember(Name = "party_leader")]
		public PartyLeader PartyLeader { get; set; }

		[Preserve]
		[DataMember(Name = "party_accept")]
		public PartyAccept PartyAccept { get; set; }

		[Preserve]
		[DataMember(Name = "party_remove")]
		public PartyMemberRemove PartyMemberRemove { get; set; }

		[DataMember(Name = "party_close")]
		[Preserve]
		public PartyClose PartyClose { get; set; }

		[Preserve]
		[DataMember(Name = "party_join_request_list")]
		public PartyJoinRequestList PartyJoinRequestList { get; set; }

		[DataMember(Name = "party_join_request")]
		[Preserve]
		public PartyJoinRequest PartyJoinRequest { get; set; }

		[Preserve]
		[DataMember(Name = "party_matchmaker_add")]
		public PartyMatchmakerAdd PartyMatchmakerAdd { get; set; }

		[Preserve]
		[DataMember(Name = "party_matchmaker_remove")]
		public PartyMatchmakerRemove PartyMatchmakerRemove { get; set; }

		[Preserve]
		[DataMember(Name = "party_matchmaker_ticket")]
		public PartyMatchmakerTicket PartyMatchmakerTicket { get; set; }

		[Preserve]
		[DataMember(Name = "party_data")]
		public PartyData PartyData { get; set; }

		[Preserve]
		[DataMember(Name = "party_data_send")]
		public PartyDataSend PartyDataSend { get; set; }

		[DataMember(Name = "party_presence_event")]
		[Preserve]
		public PartyPresenceEvent PartyPresenceEvent { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
