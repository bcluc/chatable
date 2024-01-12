namespace Chatable.Data.Entitles.Model
{
    public class Conversation
    {
		public string? conversationId { get; set; }
		public string conversationType { get; set; }

		public string conversationName { get; set; }

        public string conversationAvatar { get; set; }

        public LastMessageDTO? lastMessage { get; set; }

        public bool IsSelected { get; set; } = false;


        public bool isFriend { get; set; }

        public Conversation() { }

        public Conversation(
            string? id,
            string conversationType,
            LastMessageDTO? lastMessage,
            string conversationName,
            string conversationAvatar,
            bool isFriend
        )
        {
            conversationId = id;
            this.lastMessage = lastMessage;
            this.conversationType = conversationType;
            this.conversationName = conversationName;
            this.conversationAvatar = conversationAvatar;
            this.isFriend = isFriend;
        }
        
    }
    public class LastMessageDTO
    {
        public string senderId { get; set; }
        public string messageType { get; set; }
        public string content { get; set; }
        public DateTime sentAt { get; set; }
        public string? groupId { get; set; }
		public bool isSeen { get; set; } = true;
		public int unreadMsgCount { get; set; } = 0;

        public LastMessageDTO() { }

		public LastMessageDTO(string senderId, string messageType, string content, DateTime sentAt, string? groupId, bool? isSeen, int unreadMsgCount = 0)
		{
			this.senderId = senderId;
			this.messageType = messageType;
			this.content = content;
			this.sentAt = sentAt;
			this.groupId = groupId;
            this.isSeen = isSeen ?? true;
            this.unreadMsgCount = unreadMsgCount;
		}
	}
}
