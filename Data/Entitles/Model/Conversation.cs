namespace Chatable.Data.Entitles.Model
{
    public class Conversation
    {

        public string conversationName { get; set; }

        public string conversationAvatar { get; set; }

        public string? conversationId { get; set; }
        public LastMessageDTO? lastMessage { get; set; }
        public string conversationType { get; set; }
        public bool isFriend { get; set; }
        public bool IsSelected { get; set; }
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

		public LastMessageDTO(string senderId, string messageType, string content, DateTime sentAt, string? groupId)
		{
			this.senderId = senderId;
			this.messageType = messageType;
			this.content = content;
			this.sentAt = sentAt;
			this.groupId = groupId;
		}
	}
}
